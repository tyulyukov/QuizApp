using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizLibrary
{
    public static class App
    {
        public static readonly String Path = System.IO.Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
    }

    public interface IPresentable 
    {
        Panel Present();
    }

    public class TestCreator : IPresentable
    {
        public Test CurrentTest { get; private set; }
        public event Action OnTestChanged;

        private String Nickname;
        private readonly Image deleteIcon = Image.FromFile(App.Path + @"\Resources\delete_icon.png");
        private readonly Image addIcon = Image.FromFile(App.Path + @"\Resources\add_2_icon.png");
        private readonly Image imageIcon = Image.FromFile(App.Path + @"\Resources\image_icon.png");
        private readonly Image addAttachmentIcon = Image.FromFile(App.Path + @"\Resources\attachment_icon.png");
        private readonly OpenFileDialog fileDialog;

        public TestCreator(String nickname, Test testToEdit = null)
        {
            Nickname = nickname;
            fileDialog = new OpenFileDialog()
            {
                Filter = "Transparent Image (*.png) | *.png",
            };

            if (testToEdit == null)
                NewTest();
            else
                NewTest(testToEdit);
        }

        public void NewTest()
        {
            CurrentTest = new Test()
            {
                Id = Guid.NewGuid(),
                Author = Nickname
            };
            CurrentTest.Questions.Add(
                new Question()
                {
                    AnswersOptions = new List<AnswerOptions>()
                    {
                        new AnswerOptions()
                        {
                            Right = false
                        },
                        new AnswerOptions()
                        {
                            Right = false
                        }
                    }
                });

            OnTestChanged?.Invoke();
        }

        public void NewTest(Test test)
        {
            CurrentTest = test;

            OnTestChanged?.Invoke();
        }

        public bool CheckTest()
        {
            if (String.IsNullOrWhiteSpace(CurrentTest.Name))
                return false;

            if (CurrentTest.Questions.Count < 1 || CurrentTest.Questions.Count > 50)
                return false;

            foreach (var question in CurrentTest.Questions)
            {
                if (question.AnswersOptions.Count <= 1 || question.AnswersOptions.Count > 10)
                    return false;

                if (String.IsNullOrWhiteSpace(question.Name))
                    return false;

                int rightAnswersCount = 0;
                foreach (var answer in question.AnswersOptions)
                {
                    if (String.IsNullOrWhiteSpace(answer.Name))
                        return false;

                    if (answer.Right)
                        rightAnswersCount++;
                }

                if (rightAnswersCount == 0)
                    return false;
            }

            return true;
        }

        public Panel Present()
        {
            Panel panelTest = new Panel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                AutoScrollMargin = new Size(0, 15),
                BackColor = Color.FromArgb(23, 21, 32),
                ForeColor = Color.White,
                Size = new Size(861, 345)
            };

            Label labelEnterName = new Label()
            {
                Font = new Font("Roboto Light", 16.25f),
                Text = "Название теста (150 символов): ",
                Location = new Point(30, 20),
                AutoSize = false,
                Size = new Size(351, 36),
                TextAlign = ContentAlignment.MiddleLeft
            };

            TextBox textBoxTestName = new TextBox()
            {
                Font = new Font("Roboto Light", 15.75f),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(labelEnterName.Location.X, labelEnterName.Location.Y + 40),
                Size = new Size(panelTest.Width - (labelEnterName.Location.X * 2), 33),
                MaxLength = 150,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(14, 7, 24),
                Text = CurrentTest.Name
            };
            textBoxTestName.TextChanged += TextBoxTestName_TextChanged;
            
            int questionLastY = textBoxTestName.Location.Y + textBoxTestName.Height + 5;
            foreach(var question in CurrentTest.Questions)
            {
                int questionNumber = CurrentTest.Questions.IndexOf(question) + 1;

                GroupBox groupBoxQuestion = new GroupBox()
                {
                    Tag = questionNumber,
                    Text = $"Вопрос #{questionNumber}: ",
                    Font = new Font("Roboto Thin", 13.75f),
                    Location = new Point(labelEnterName.Location.X, questionLastY),
                    Size = new Size(panelTest.Width - (labelEnterName.Location.X * 2), 275 + (question.AnswersOptions.Count * 30)),
                    ForeColor = Color.White
                };

                questionLastY += groupBoxQuestion.Height + 5;

                PictureBox attachment = new PictureBox()
                {
                    Size = new Size(115, 115),
                    Location = new Point(30, 26),
                    BorderStyle = BorderStyle.FixedSingle
                };

                if (!String.IsNullOrEmpty(question.Base64ImageRepresentation))
                {
                    attachment.SizeMode = PictureBoxSizeMode.Zoom;
                    attachment.Image = Encoder.GetImage(question.Base64ImageRepresentation);
                }
                else
                {
                    attachment.SizeMode = PictureBoxSizeMode.CenterImage;
                    attachment.Image = imageIcon;
                }
                    

                PictureBox buttonAddAttachment = new PictureBox()
                {
                    Tag = $"{questionNumber}",
                    Image = addAttachmentIcon,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(40, 40),
                    Cursor = Cursors.Hand
                };
                buttonAddAttachment.Location = new Point(attachment.Location.X + attachment.Width + 10, attachment.Location.Y + attachment.Height - buttonAddAttachment.Height);
                buttonAddAttachment.Click += ButtonAddAttachment_Click;

                PictureBox buttonDeleteAttachment = new PictureBox()
                {
                    Tag = $"{questionNumber}",
                    Image = deleteIcon,
                    Size = new Size(40, 40),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    Location = new Point(buttonAddAttachment.Location.X + buttonAddAttachment.Width + 5, buttonAddAttachment.Location.Y)
                };
                buttonDeleteAttachment.Click += ButtonDeleteAttachment_Click;

                TextBox textBoxQuestionName = new TextBox()
                {
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(14, 7, 24),
                    Font = new Font("Roboto Light", 13.75f),
                    Tag = questionNumber,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(attachment.Location.X, attachment.Location.Y + attachment.Height + 10),
                    Size = new Size(groupBoxQuestion.Width - (labelEnterName.Location.X * 2), 30),
                    MaxLength = 150,
                    Text = question.Name
                };
                textBoxQuestionName.TextChanged += TextBoxQuestionName_TextChanged;

                int answerLastY = textBoxQuestionName.Location.Y + textBoxQuestionName.Height + 5;
                foreach (var answer in question.AnswersOptions)
                {
                    int answerNumber = question.AnswersOptions.IndexOf(answer) + 1;

                    CheckBox checkBoxAnswer = new CheckBox()
                    {
                        Checked = answer.Right,
                        Location = new Point(textBoxQuestionName.Location.X, answerLastY + 1),
                        Font = new Font("Roboto Thin", 12.75f),
                        Text = $"{answerNumber}:",
                        Tag = $"{questionNumber}-{answerNumber}",
                        AutoSize = false,
                        Size = new Size(50, 24)
                    };
                    checkBoxAnswer.CheckedChanged += CheckBoxAnswer_CheckedChanged;

                    TextBox textBoxAnswer = new TextBox()
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(14, 7, 24),
                        Location = new Point(textBoxQuestionName.Location.X + checkBoxAnswer.Width, answerLastY),
                        Font = new Font("Roboto Thin", 12.75f),
                        Size = new Size(groupBoxQuestion.Width - checkBoxAnswer.Width - 175, 28),
                        Tag = $"{questionNumber}-{answerNumber}",
                        Text = answer.Name,
                        MaxLength = 150,
                    };
                    textBoxAnswer.TextChanged += TextBoxAnswer_TextChanged;

                    PictureBox buttonDeleteAnswer = new PictureBox()
                    {
                        Image = deleteIcon,
                        Size = new Size(27, 27),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Cursor = Cursors.Hand,
                        Tag = $"{questionNumber}-{answerNumber}",
                        Location = new Point(textBoxAnswer.Location.X + textBoxAnswer.Width + 5, answerLastY)
                    };
                    buttonDeleteAnswer.Click += ButtonDeleteAnswer_Click;

                    answerLastY += checkBoxAnswer.Height + 5;

                    groupBoxQuestion.Controls.Add(buttonDeleteAnswer);
                    groupBoxQuestion.Controls.Add(textBoxAnswer);
                    groupBoxQuestion.Controls.Add(checkBoxAnswer);
                }

                PictureBox buttonAddAnswer = new PictureBox()
                {
                    Image = addIcon,
                    Size = new Size(27, 27),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    Tag = $"{questionNumber}",
                    Location = new Point(textBoxQuestionName.Location.X, answerLastY)
                };
                buttonAddAnswer.Click += ButtonAddAnswer_Click;

                PictureBox buttonDeleteQuestion = new PictureBox()
                {
                    Image = deleteIcon,
                    Size = new Size(50, 50),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    Tag = $"{questionNumber}"
                };
                buttonDeleteQuestion.Location = new Point(groupBoxQuestion.Width - buttonDeleteQuestion.Width - 5, groupBoxQuestion.Height - buttonDeleteQuestion.Height - 5);
                buttonDeleteQuestion.Click += ButtonDeleteQuestion_Click;

                groupBoxQuestion.Controls.Add(buttonDeleteAttachment);
                groupBoxQuestion.Controls.Add(attachment);
                groupBoxQuestion.Controls.Add(buttonAddAttachment);
                groupBoxQuestion.Controls.Add(buttonDeleteQuestion);
                groupBoxQuestion.Controls.Add(buttonAddAnswer);
                groupBoxQuestion.Controls.Add(textBoxQuestionName);

                panelTest.Controls.Add(groupBoxQuestion);
            }

            PictureBox buttonAddQuestion = new PictureBox()
            {
                Image = addIcon,
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand
            };
            buttonAddQuestion.Location = new Point(panelTest.Width / 2 - buttonAddQuestion.Width / 2, questionLastY);
            buttonAddQuestion.Click += ButtonAddQuestion_Click;

            panelTest.Controls.Add(buttonAddQuestion);
            panelTest.Controls.Add(labelEnterName);
            panelTest.Controls.Add(textBoxTestName);

            return panelTest;
        }

        private void ButtonDeleteAttachment_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;

            CurrentTest.Questions[Convert.ToInt32(button.Tag) - 1].Base64ImageRepresentation = String.Empty;

            OnTestChanged?.Invoke();
        }

        private void ButtonAddAttachment_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;

            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            CurrentTest.Questions[Convert.ToInt32(button.Tag) - 1].Base64ImageRepresentation = Encoder.GetBase64String(fileDialog.FileName);
            
            OnTestChanged?.Invoke();
        }

        private void ButtonDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (CurrentTest.Questions.Count == 1)
                return;

            PictureBox button = sender as PictureBox;
            CurrentTest.Questions.RemoveAt(Convert.ToInt32(button.Tag) - 1);

            OnTestChanged?.Invoke();
        }

        private void ButtonAddAnswer_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;
            
            if (CurrentTest.Questions[Convert.ToInt32(button.Tag) - 1].AnswersOptions.Count >= 10)
                return;

            CurrentTest.Questions[Convert.ToInt32(button.Tag) - 1].AnswersOptions.Add(new AnswerOptions() { Right = false });

            OnTestChanged?.Invoke();
        }

        private void ButtonDeleteAnswer_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;

            String[] parsingNumbers = button.Tag.ToString().Split('-');
            int questionNumber = Convert.ToInt32(parsingNumbers[0]) - 1;
            int answerNumber = Convert.ToInt32(parsingNumbers[1]) - 1;
            
            if (CurrentTest.Questions[questionNumber].AnswersOptions.Count == 1)
                return;

            CurrentTest.Questions[questionNumber].AnswersOptions.RemoveAt(answerNumber);

            OnTestChanged?.Invoke();
        }

        private void TextBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            String[] parsingNumbers = textBox.Tag.ToString().Split('-');
            int questionNumber = Convert.ToInt32(parsingNumbers[0]) - 1;
            int answerNumber = Convert.ToInt32(parsingNumbers[1]) - 1;

            CurrentTest.Questions[questionNumber].AnswersOptions[answerNumber].Name = textBox.Text;
        }

        private void CheckBoxAnswer_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            String[] parsingNumbers = checkBox.Tag.ToString().Split('-');
            int questionNumber = Convert.ToInt32(parsingNumbers[0]) - 1;
            int answerNumber = Convert.ToInt32(parsingNumbers[1]) - 1;

            CurrentTest.Questions[questionNumber].AnswersOptions[answerNumber].Right = checkBox.Checked;
        }

        private void TextBoxQuestionName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            CurrentTest.Questions[Convert.ToInt32(textBox.Tag) - 1].Name = textBox.Text;
        }

        private void ButtonAddQuestion_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;

            if (CurrentTest.Questions.Count >= 50)
                return;

            CurrentTest.Questions.Add(
                new Question()
                {
                    AnswersOptions = new List<AnswerOptions>()
                    {
                        new AnswerOptions()
                        {
                            Right = false
                        },
                        new AnswerOptions()
                        {
                            Right = false
                        }
                    }
                });

            OnTestChanged?.Invoke();
        }

        private void TextBoxTestName_TextChanged(object sender, EventArgs e)
        {
            CurrentTest.Name = (sender as TextBox).Text;
        }
    }

    public class TestPresenter : IPresentable
    {
        public Test PresentableTest { get; private set; }
        public event EventHandler ButtonPassClick;

        public TestPresenter(Test test, EventHandler buttonPassClick)
        {
            PresentableTest = test;
            ButtonPassClick = buttonPassClick;
        }

        public Panel Present()
        {
            Panel panelTest = new Panel()
            {
                BackColor = Color.FromArgb(17, 10, 27),
                ForeColor = Color.White,
                Size = new Size(843, 150),
            };

            Label testName = new Label()
            {
                Text = PresentableTest.Name,
                Location = new Point(18, 10),
                Font = new Font("Roboto", 14.5f),
                AutoSize = false,
            };

            if (PresentableTest.Name.Length > 30)
            {
                testName.Size = new Size(panelTest.Width - (testName.Location.X * 2), panelTest.Height - 30);
            }
            else
            {
                testName.AutoSize = true;
                panelTest.Height = 100;
            }

            Label countQuestions = new Label()
            {
                Text = $"Количество вопросов: {PresentableTest.Questions.Count}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true
            };
            countQuestions.Location = new Point(20, panelTest.Height - 7 - countQuestions.Height);

            Label authorName = new Label()
            {
                Text = $"Автор: {PresentableTest.Author}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true,
                Location = new Point(100 + countQuestions.Width, panelTest.Height - 7 - countQuestions.Height)
            };

            Button buttonPassTest = new Button()
            {
                AutoSize = false,
                Size = new Size(120, 35),
                FlatStyle = FlatStyle.Flat,
                Text = "Пройти",
                Font = new Font("Roboto Bold", 13.5f),
                Tag = PresentableTest
            };
            buttonPassTest.Location = new Point(panelTest.Width - buttonPassTest.Width - 10, panelTest.Height - buttonPassTest.Height - 10);

            if (ButtonPassClick != null)
                buttonPassTest.Click += ButtonPassClick;

            panelTest.Controls.Add(authorName);
            panelTest.Controls.Add(buttonPassTest);
            panelTest.Controls.Add(countQuestions);
            panelTest.Controls.Add(testName);
            return panelTest;
        }
    }

    public class MyTestPresenter : IPresentable
    {
        public Test PresentableTest { get; private set; }

        private readonly Image deleteIcon = Image.FromFile(App.Path + @"\Resources\delete_icon.png");
        private readonly Image editIcon = Image.FromFile(App.Path + @"\Resources\edit_icon.png");
        private readonly Image statisticsIcon = Image.FromFile(App.Path + @"\Resources\analytics_icon.png");

        private EventHandler ButtonDeleteTestClick, ButtonEditTestClick, ButtonStatisticsClick;

        public MyTestPresenter(Test test, EventHandler buttonDeleteTestClick, EventHandler buttonEditTestClick, EventHandler buttonStatisticsClick)
        {
            PresentableTest = test;
            ButtonDeleteTestClick = buttonDeleteTestClick;
            ButtonEditTestClick = buttonEditTestClick;
            ButtonStatisticsClick = buttonStatisticsClick;
        }

        public Panel Present()
        {
            Panel panelTest = new Panel()
            {
                BackColor = Color.FromArgb(17, 10, 27),
                ForeColor = Color.White,
                Size = new Size(843, 150),
            };

            Label testName = new Label()
            {
                Text = PresentableTest.Name,
                Location = new Point(18, 10),
                Font = new Font("Roboto", 14.5f),
                AutoSize = false,
            };

            if (PresentableTest.Name.Length > 30)
            {
                testName.Size = new Size(panelTest.Width - (testName.Location.X * 2), panelTest.Height - 30);
            }
            else
            {
                testName.AutoSize = true;
                panelTest.Height = 100;
            }

            Label countQuestions = new Label()
            {
                Text = $"Количество вопросов: {PresentableTest.Questions.Count}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true
            };
            countQuestions.Location = new Point(20, panelTest.Height - 7 - countQuestions.Height);

            TextBox testId = new TextBox()
            {
                ReadOnly = true,
                Font = new Font("Roboto Light", 10f),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(17, 10, 27),
                Location = new Point(countQuestions.Location.X + 2, countQuestions.Location.Y - countQuestions.Height - 9),
                Size = new Size(350, 15),
                Text = PresentableTest.Id.ToString()
            };

            PictureBox buttonDeleteTest = new PictureBox()
            {
                Image = deleteIcon,
                Size = new Size(27, 27),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand,
                Tag = PresentableTest
            };
            buttonDeleteTest.Location = new Point(panelTest.Width - buttonDeleteTest.Width - 10, panelTest.Height - buttonDeleteTest.Height - 10);
            buttonDeleteTest.Click += ButtonDeleteTestClick;

            PictureBox buttonEditTest = new PictureBox()
            {
                Image = editIcon,
                Size = new Size(27, 27),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand,
                Tag = PresentableTest
            };
            buttonEditTest.Location = new Point(buttonDeleteTest.Location.X - buttonEditTest.Width - 10, panelTest.Height - buttonEditTest.Height - 10);
            buttonEditTest.Click += ButtonEditTestClick;

            PictureBox buttonStatistics = new PictureBox()
            {
                Image = statisticsIcon,
                Size = new Size(27, 27),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand,
                Tag = PresentableTest
            };
            buttonStatistics.Location = new Point(buttonEditTest.Location.X - buttonStatistics.Width - 10, panelTest.Height - buttonStatistics.Height - 10);
            buttonStatistics.Click += ButtonStatisticsClick;

            panelTest.Controls.Add(testId);
            panelTest.Controls.Add(buttonDeleteTest);
            panelTest.Controls.Add(buttonEditTest);
            panelTest.Controls.Add(buttonStatistics);
            panelTest.Controls.Add(countQuestions);
            panelTest.Controls.Add(testName);
            return panelTest;
        }
    }

    public class MyStatisticPresenter : IPresentable
    {
        public Statistic PresentableStatistic { get; private set; }

        public MyStatisticPresenter(Statistic statistic)
        {
            PresentableStatistic = statistic;
        }

        public Panel Present()
        {
            Panel panelTest = new Panel()
            {
                BackColor = Color.FromArgb(17, 10, 27),
                ForeColor = Color.White,
                Size = new Size(843, 175),
            };

            Label testName = new Label()
            {
                Text = PresentableStatistic.TestName,
                Location = new Point(18, 10),
                Font = new Font("Roboto", 14.5f),
                AutoSize = false
            };

            if (PresentableStatistic.TestName.Length > 30)
            {
                testName.Size = new Size(panelTest.Width - (testName.Location.X * 2), panelTest.Height - 30);
            }
            else
            {
                testName.AutoSize = true;
                panelTest.Height = 125;
            }

            Label score = new Label()
            {
                Text = $"Счёт: {PresentableStatistic.Score}/{PresentableStatistic.MaxScore}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true,
                Location = new Point(testName.Location.X, testName.Location.Y + testName.Height + 6)
            };

            Label time = new Label()
            {
                Text = $"Время прохождения: {PresentableStatistic.PassTime}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true,
                Location = new Point(score.Location.X, score.Location.Y + score.Height + 3)
            };

            Label date = new Label()
            {
                Text = $"Дата: {PresentableStatistic.PassDate}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true,
                Location = new Point(time.Location.X, time.Location.Y + time.Height + 3)
            };

            panelTest.Controls.Add(date);
            panelTest.Controls.Add(time);
            panelTest.Controls.Add(score);
            panelTest.Controls.Add(testName);
            return panelTest;
        }
    }

    public class MyTestStatisticPresenter : IPresentable
    {
        public Statistic PresentableStatistic { get; private set; }

        public MyTestStatisticPresenter(Statistic statistic)
        {
            PresentableStatistic = statistic;
        }

        public Panel Present()
        {
            Panel panelTest = new Panel()
            {
                BackColor = Color.FromArgb(17, 10, 27),
                ForeColor = Color.White,
                Size = new Size(843, 125),
            };

            Label nickname = new Label()
            {
                Text = PresentableStatistic.UserNickname,
                Location = new Point(18, 10),
                Font = new Font("Roboto", 14.5f),
                AutoSize = false
            };

            Label score = new Label()
            {
                Text = $"Счёт: {PresentableStatistic.Score}/{PresentableStatistic.MaxScore}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true,
                Location = new Point(nickname.Location.X, nickname.Location.Y + nickname.Height + 6)
            };

            Label time = new Label()
            {
                Text = $"Время прохождения: {PresentableStatistic.PassTime}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true,
                Location = new Point(score.Location.X, score.Location.Y + score.Height + 3)
            };

            Label date = new Label()
            {
                Text = $"Дата: {PresentableStatistic.PassDate}",
                Font = new Font("Roboto Light", 10f),
                AutoSize = true,
                Location = new Point(time.Location.X, time.Location.Y + time.Height + 3)
            };

            panelTest.Controls.Add(date);
            panelTest.Controls.Add(time);
            panelTest.Controls.Add(score);
            panelTest.Controls.Add(nickname);
            return panelTest;
        }
    }

    public class TestPassing : IPresentable
    {
        public Test CurrentTest { get; private set; }
        public AnswersDictionary Answers => new AnswersDictionary(CurrentTest.Id, Time, Date, dictionary);

        public TimeSpan Time;
        public DateTime Date;

        private Dictionary<int, Dictionary<int, bool>> dictionary = new Dictionary<int, Dictionary<int, bool>>();

        public TestPassing(Test test)
        {
            CurrentTest = test;

            for (int i = 0; i < test.Questions.Count; i++)
            {
                var answersOnQuestion = new Dictionary<int, bool>();

                for (int j = 0; j < test.Questions[i].AnswersOptions.Count; j++)
                    answersOnQuestion.Add(j, test.Questions[i].AnswersOptions[j].Right);
                
                dictionary.Add(i, answersOnQuestion);
            }
        }

        public Panel Present()
        {
            Panel panelTest = new Panel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                AutoScrollMargin = new Size(0, 15),
                BackColor = Color.FromArgb(23, 21, 32),
                ForeColor = Color.White,
                Size = new Size(861, 345)
            };

            Label labelTestName = new Label()
            {
                AutoSize = false,
                Font = new Font("Roboto", 18f),
                Location = new Point(30, 20),
                Size = new Size(panelTest.Width - (30 * 2), 36),
                ForeColor = Color.White,
                Text = CurrentTest.Name
            };

            int questionLastY = labelTestName.Location.Y + labelTestName.Height + 5;
            foreach (var question in CurrentTest.Questions)
            {
                int questionNumber = CurrentTest.Questions.IndexOf(question) + 1;

                GroupBox groupBoxQuestion = new GroupBox()
                {
                    Tag = questionNumber,
                    Text = $"Вопрос #{questionNumber}: ",
                    Font = new Font("Roboto Thin", 18f),
                    Location = new Point(labelTestName.Location.X, questionLastY),
                    Size = new Size(panelTest.Width - (labelTestName.Location.X * 2), 70 + (question.AnswersOptions.Count * 30)),
                    ForeColor = Color.White
                };

                questionLastY += groupBoxQuestion.Height + 5;

                PictureBox attachment = null;
                if (!String.IsNullOrEmpty(question.Base64ImageRepresentation))
                {
                    attachment = new PictureBox()
                    {
                        Size = new Size(115, 115),
                        Location = new Point(30, 26),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = Encoder.GetImage(question.Base64ImageRepresentation)
                    };
                    groupBoxQuestion.Controls.Add(attachment);
                }

                Label textBoxQuestionName = new Label()
                {
                    ForeColor = Color.White,
                    Font = new Font("Roboto Light", 16.5f),
                    Tag = questionNumber,
                    Location = new Point(30, 30),
                    Size = new Size(groupBoxQuestion.Width - (labelTestName.Location.X * 2), 30),
                    Text = question.Name
                };

                if (attachment != null)
                {
                    textBoxQuestionName.Location = new Point(attachment.Location.X, 150);
                    groupBoxQuestion.Height += attachment.Height + 5;
                    questionLastY += attachment.Height + 5;
                }

                int answerLastY = textBoxQuestionName.Location.Y + textBoxQuestionName.Height + 5;
                foreach (var answer in question.AnswersOptions)
                {
                    int answerNumber = question.AnswersOptions.IndexOf(answer) + 1;

                    Control checkBoxAnswer;
                    if (question.AnswersOptions.Count > 1)
                    {
                        CheckBox checkBox = new CheckBox()
                        {
                            ForeColor = Color.White,
                            Checked = false,
                            Location = new Point(textBoxQuestionName.Location.X, answerLastY + 1),
                            Font = new Font("Roboto Thin", 15.75f),
                            Text = $"{answerNumber}:",
                            Tag = $"{questionNumber}-{answerNumber}",
                            AutoSize = false,
                            Size = new Size(50, 24)
                        };
                        checkBox.CheckedChanged += AnswerOption_CheckedChanged;

                        checkBoxAnswer = checkBox;
                    }
                    else
                    {
                        RadioButton radioButton = new RadioButton()
                        {
                            ForeColor = Color.White,
                            Checked = false,
                            Location = new Point(textBoxQuestionName.Location.X, answerLastY + 1),
                            Font = new Font("Roboto Thin", 15.75f),
                            Text = $"{answerNumber}:",
                            Tag = $"{questionNumber}-{answerNumber}",
                            AutoSize = false,
                            Size = new Size(50, 24)
                        };
                        radioButton.CheckedChanged += AnswerOption_CheckedChanged;

                        checkBoxAnswer = radioButton;
                    }

                    Label answerText = new Label()
                    {
                        ForeColor = Color.White,
                        Location = new Point(textBoxQuestionName.Location.X + checkBoxAnswer.Width, answerLastY),
                        Font = new Font("Roboto Thin", 15.75f),
                        Size = new Size(groupBoxQuestion.Width - checkBoxAnswer.Width - 175, 28),
                        Tag = $"{questionNumber}-{answerNumber}",
                        Text = answer.Name
                    };

                    answerLastY += checkBoxAnswer.Height + 5;

                    groupBoxQuestion.Controls.Add(answerText);
                    groupBoxQuestion.Controls.Add(checkBoxAnswer);
                }

                groupBoxQuestion.Controls.Add(textBoxQuestionName);

                panelTest.Controls.Add(groupBoxQuestion);
            }

            panelTest.Controls.Add(labelTestName);

            return panelTest;
        }

        private void AnswerOption_CheckedChanged(object sender, EventArgs e)
        {
            String[] parsingNumbers = (sender as Control).Tag.ToString().Split('-');
            int questionNumber = Convert.ToInt32(parsingNumbers[0]) - 1;
            int answerNumber = Convert.ToInt32(parsingNumbers[1]) - 1;

            CheckBox checkBox = sender as CheckBox;

            if (checkBox == null)
            {
                RadioButton radioButton = sender as RadioButton;
                dictionary[questionNumber][answerNumber] = radioButton.Checked;
            }
            else
            {
                dictionary[questionNumber][answerNumber] = checkBox.Checked;
            }
        }
    }
}
