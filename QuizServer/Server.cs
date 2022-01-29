using QuizLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace ClientServer
{
    public class Server
    {
        public bool IsActive { get; set; }
        public int LocalPort { get; private set; }
        public IPAddress Address { get; private set; }

        public event Action<String> ShowMessage;

        private TcpListener listener;
        private QuizServer.QuizAppDBEntities DB;
        private List<Test> Tests;

        public Server(String ip, int port)
        {
            LocalPort = port;
            Address = IPAddress.Parse(ip);
            listener = null;
            DB = new QuizServer.QuizAppDBEntities();
            IsActive = false;
        }

        public void Start()
        {
            if (listener != null)
                return;

            try
            {
                listener = new TcpListener(IPAddress.Any, LocalPort);
                listener.Start(10);

                LoadTests();

                IsActive = true;
                ShowMessage?.Invoke("Server started");

                while (IsActive)
                    AcceptClient();
            }
            catch (Exception ex)
            {
                listener = null;
                ShowMessage?.Invoke(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
                ShowMessage?.Invoke("Server stopped");
            }
        }

        private void LoadTests()
        {
            var entityTests = DB.Tests.ToList();

            Tests = new List<Test>();
            foreach (var entity in entityTests)
                Tests.Add(ConvertToTypedObject(entity));
        }

        private void AcceptClient()
        {
            TcpClient client = listener.AcceptTcpClient();
            ShowMessage?.Invoke($"Connection from {client.Client.RemoteEndPoint}");

            new Thread(Receive).Start(client);
        }

        private void Receive(object _client)
        {
            TcpClient client = _client as TcpClient;
            BinaryFormatter binary = new BinaryFormatter();
            Request request;
            Response response;

            try
            {
                do
                {
                    request = binary.Deserialize(client.GetStream()) as Request;

                    ShowMessage?.Invoke($"Request from {request.Sender} - {client.Client.RemoteEndPoint}: {request.Type} -> {request.Message}");

                    if (request.Type == RequestType.Disconnecting)
                    {
                        ShowMessage?.Invoke($"Response to {request.Sender} - {client.Client.RemoteEndPoint}: {request.Type} -> User disconnected");
                        break;
                    }

                    response = Process(request);

                    ShowMessage?.Invoke($"Response to {request.Sender} - {client.Client.RemoteEndPoint}: {request.Type} -> {response.Message}");

                    binary.Serialize(client.GetStream(), response);
                } while (IsActive);
            }
            finally
            {
                client.GetStream().Close();
                client.Close();
            }
        }

        private Response Process(Request request)
        {
            if (request.Type == RequestType.Authorization)
            {
                var users = DB.Users.ToList();

                if (users.Count == 0)
                {
                    return new Response("Users are not loaded to server", false);
                }
                else
                {
                    foreach (var user in users)
                        if (user.Nickname == request.Sender && user.PasswordHash == request.Message)
                            return new Response("User authorized", true);

                    return new Response("User is not found", false);
                }
            }
            else if (request.Type == RequestType.IsNicknameExisting)
            {
                var nicknames = DB.Users.Select(user => user.Nickname).ToList();

                if (nicknames.Count == 0)
                {
                    return new Response("Users are not loaded to database", false);
                }
                else
                {
                    foreach (var nickname in nicknames)
                        if (nickname == request.Sender)
                            return new Response($"{nickname} existing", true);

                    return new Response($"{request.Sender} is not existing", false);
                }
            }
            else if (request.Type == RequestType.Registration)
            {
                try
                {
                    QuizServer.Users newUser = new QuizServer.Users()
                    {
                        Nickname = request.Sender,
                        PasswordHash = request.Message
                    };

                    DB.Users.Add(newUser);
                    DB.SaveChanges();
                    return new Response("User is registered", true);
                }
                catch { return new Response("Can`t register this user", false); }
            }
            else if (request.Type == RequestType.CreatingTest)
            {
                try
                {
                    Test test = request.Parameter as Test;

                    QuizServer.Tests normalizedTest = ConvertToEntity(test);
                    
                    test.Id = DB.Tests.Add(normalizedTest).Id;
                    
                    Tests.Add(test);
                    DB.SaveChanges();

                    return new Response("Test created succesfully", true);
                }
                catch { return new Response("Can`t create test", false); }
            }
            else if (request.Type == RequestType.GetTests)
            {
                try
                {
                    TestsCollection testsCollection = new TestsCollection(Tests);
                    return new Response($"{testsCollection.Tests.Count} tests sent", testsCollection);
                }
                catch { return new Response("Can`t load tests from database", false); }
            }
            else if (request.Type == RequestType.GetMyTests)
            {
                try
                {
                    TestsCollection testsCollection = new TestsCollection(Tests.Where(test => test.Author == request.Sender).ToList());
                    return new Response($"{testsCollection.Tests.Count} tests sent", testsCollection);
                }
                catch { return new Response("Can`t load tests from database", false); }
            }
            else if (request.Type == RequestType.GetMyStatistics)
            {
                try
                {
                    var userId = DB.Users.FirstOrDefault(user => user.Nickname == request.Sender).Id;
                    var entityStatistics = DB.Statistics.Where(stat => stat.UserId == userId).ToList();

                    List<Statistic> objectStatistics = new List<Statistic>();
                    foreach (var entity in entityStatistics)
                        objectStatistics.Add(ConvertToTypedObject(entity));

                    StatisticsCollection statisticsCollection = new StatisticsCollection(objectStatistics);

                    return new Response($"{statisticsCollection.Statistics.Count} statistics sent", statisticsCollection);
                }
                catch { return new Response("Can`t load your statistics from database", false); }
            }
            else if (request.Type == RequestType.GetTestStatistics)
            {
                try
                {
                    var testId = Guid.Parse(request.Message);
                    var entityStatistics = DB.Statistics.Where(stat => stat.TestId == testId).ToList();

                    List<Statistic> objectStatistics = new List<Statistic>();
                    foreach (var entity in entityStatistics)
                        objectStatistics.Add(ConvertToTypedObject(entity));

                    StatisticsCollection statisticsCollection = new StatisticsCollection(objectStatistics);

                    return new Response($"{statisticsCollection.Statistics.Count} statistics sent", statisticsCollection);
                }
                catch { return new Response("Can`t load your statistics from database", false); }
            }
            else if (request.Type == RequestType.CheckingAnswers)
            {
                try
                {
                    AnswersDictionary answers = request.Parameter as AnswersDictionary;

                    var test = Tests.FirstOrDefault(t => t.Id == answers.TestId);

                    int maxScore = test.Questions.Count;
                    int score = 0;
                    bool scoreRequired = true;

                    for (int i = 0; i < test.Questions.Count; i++)
                    {
                        scoreRequired = true;
                        for (int j = 0; j < test.Questions[i].AnswersOptions.Count; j++)
                        {
                            if (test.Questions[i].AnswersOptions[j].Right != answers.Answers[i][j])
                            {
                                scoreRequired = false;
                                break;
                            }
                        }

                        if (scoreRequired)
                            score++;
                    }

                    var statistic = new QuizServer.Statistics()
                    {
                        TestId = answers.TestId,
                        PassDate = answers.PassDate,
                        PassTime = answers.PassingTime,
                        Score = score,
                        MaxScore = maxScore,
                        UserId = DB.Users.FirstOrDefault(u => u.Nickname == request.Sender).Id,
                    };

                    DB.Statistics.Add(statistic);
                    DB.SaveChanges();

                    return new Response($"{score}/{maxScore}", true);
                }
                catch { return new Response("Can`t check your answers", false); }
            }
            else if (request.Type == RequestType.GetTestById)
            {
                try
                {
                    var test = DB.Tests.FirstOrDefault(t => t.Id == Guid.Parse(request.Message));
                    return new Response("Test found", ConvertToTypedObject(test));
                }
                catch { return new Response("Can`t find test", false); }
            }
            else if (request.Type == RequestType.DeleteTest)
            {
                try
                {
                    Guid testId = (request.Parameter as Test).Id;
                    Test test = Tests.FirstOrDefault(t => t.Id == testId);
                    QuizServer.Tests entityTest = DB.Tests.FirstOrDefault(t => t.Id == test.Id);

                    var statistics = DB.Statistics.Where(stat => stat.TestId == test.Id).ToList();
                    foreach (var stat in statistics)
                        DB.Statistics.Remove(stat);

                    var questions = DB.Questions.Where(question => question.TestId == test.Id).ToList();
                    List<QuizServer.Answers> answers = new List<QuizServer.Answers>();
                    foreach (var question in questions)
                        answers.AddRange(question.Answers);

                    foreach (var answer in answers)
                        DB.Answers.Remove(answer);

                    foreach (var question in questions)
                        DB.Questions.Remove(question);

                    Tests.Remove(test);
                    DB.Tests.Remove(entityTest);
                    DB.SaveChanges();

                    return new Response("Test deleted", true);
                }
                catch { return new Response("Can`t delete test", false); }
            }
            else if (request.Type == RequestType.EditingTest)
            {
                try
                {
                    Test editedTest = request.Parameter as Test;
                    int index = -1;

                    for (int i = 0; i < Tests.Count; i++)
                        if (Tests[i].Id == editedTest.Id)
                        {
                            index = i;
                            break;
                        }

                    if (index == -1)
                        return new Response("Can`t find test to edit", false);

                    Tests[index] = editedTest;

                    QuizServer.Tests entityTestToEdit = null;

                    foreach (var entity in DB.Tests.ToList())
                        if (entity.Id == editedTest.Id)
                        {
                            entityTestToEdit = entity;
                            break;
                        }

                    if (entityTestToEdit == null)
                        return new Response("Can`t find test to edit", false);

                    var statistics = DB.Statistics.Where(stat => stat.TestId == editedTest.Id).ToList();
                    foreach (var stat in statistics)
                        DB.Statistics.Remove(stat);

                    var questions = DB.Questions.Where(question => question.TestId == editedTest.Id).ToList();
                    List<QuizServer.Answers> answers = new List<QuizServer.Answers>();
                    foreach (var question in questions)
                        answers.AddRange(question.Answers);

                    foreach (var answer in answers)
                        DB.Answers.Remove(answer);

                    foreach (var question in questions)
                        DB.Questions.Remove(question);

                    DB.Tests.Remove(entityTestToEdit);
                    DB.Tests.Add(ConvertToEntity(editedTest));

                    DB.SaveChanges();

                    return new Response("Test edited", true);
                }
                catch { return new Response("Can`t edit test", false); }
            }

            return new Response("Unknown request", false);
        }

        private QuizServer.Tests ConvertToEntity(Test test)
        {
            QuizServer.Tests normalizedTest = new QuizServer.Tests()
            {
                Id = test.Id,
                Name = test.Name,
                AuthorId = DB.Users.FirstOrDefault(user => user.Nickname == test.Author).Id
            };

            foreach (var question in test.Questions)
            {
                String imagePath = String.Empty;
                String imageName = String.Empty;
                if (!String.IsNullOrEmpty(question.Base64ImageRepresentation))
                {
                    var image = Encoder.GetImage(question.Base64ImageRepresentation);

                    if (!Directory.Exists(AppContext.BaseDirectory + @"Images"))
                        Directory.CreateDirectory(AppContext.BaseDirectory + @"Images");

                    imagePath = AppContext.BaseDirectory + $@"Images\";
                    imageName = $"image{test.Questions.IndexOf(question)}_{DateTime.Now.ToString("MMddyyHmmssFF")}.png";
                    image.Save(imagePath + imageName, image.RawFormat);
                }

                QuizServer.Questions newQuestion = new QuizServer.Questions()
                {
                    TestId = normalizedTest.Id,
                    Question = question.Name,
                };

                if (!String.IsNullOrEmpty(imagePath))
                    newQuestion.ImagePath = imageName;

                normalizedTest.Questions.Add(newQuestion);

                foreach (var answer in question.AnswersOptions)
                {
                    QuizServer.Answers newAnswer = new QuizServer.Answers()
                    {
                        QuestionId = newQuestion.Id,
                        Answer = answer.Name,
                        Right = answer.Right,
                    };
                    newQuestion.Answers.Add(newAnswer);
                }
            }

            return normalizedTest;
        }

        private Test ConvertToTypedObject(QuizServer.Tests test)
        {
            Test normalizedTest = new Test()
            {
                Id = test.Id,
                Name = test.Name,
                Author = DB.Users.FirstOrDefault(user => user.Id == test.AuthorId).Nickname
            };

            foreach (var question in test.Questions)
            {
                Question newQuestion = new Question()
                {
                    Name = question.Question
                };

                if (!String.IsNullOrEmpty(question.ImagePath))
                    newQuestion.Base64ImageRepresentation = Encoder.GetBase64String(AppContext.BaseDirectory + @"\Images\" + question.ImagePath);

                normalizedTest.Questions.Add(newQuestion);

                foreach (var answer in question.Answers)
                {
                    AnswerOptions newAnswerOption = new AnswerOptions()
                    {
                        Name = answer.Answer,
                        Right = answer.Right
                    };

                    newQuestion.AnswersOptions.Add(newAnswerOption);
                }
            }

            return normalizedTest;
        }

        private Statistic ConvertToTypedObject(QuizServer.Statistics statistics)
        {
            Statistic normalizedStatistic = new Statistic(statistics.PassDate, statistics.PassTime, statistics.Score, statistics.MaxScore, statistics.Tests.Name, statistics.Users.Nickname);
            return normalizedStatistic;
        }
    }
}
