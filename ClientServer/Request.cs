using QuizLibrary;
using System;

namespace ClientServer
{
    [Serializable]
    public class Request
    {
        public static Request Empty => new Request(RequestType.None, String.Empty, String.Empty);

        public RequestType Type { get; private set; }
        public String Sender { get; private set; }
        public String Message { get; private set; }
        public object Parameter { get; private set; }

        public Request(RequestType type, String sender, String message)
        {
            Type = type;
            Sender = sender;
            Message = message;
        }

        public Request(RequestType type, String sender, String message, Guid id)
        {
            Type = type;
            Sender = sender;
            Message = message;
            Parameter = id;
        }

        public Request(RequestType type, String sender, String message, AnswersDictionary answers)
        {
            Type = type;
            Sender = sender;
            Message = message;
            Parameter = answers;
        }

        public Request(RequestType type, String sender, String message, Test test)
        {
            Type = type;
            Sender = sender;
            Message = message;
            Parameter = test;
        }

        public virtual bool IsEmpty() => Type == RequestType.None && String.IsNullOrEmpty(Sender) && String.IsNullOrEmpty(Message);
    }

    public enum RequestType
    {
        None = 0,
        Authorization = 1,
        Registration = 2,
        IsNicknameExisting = 3,
        CheckingAnswers = 4,
        CreatingTest = 5,
        GetNicknameById = 6,
        GetTests = 7,
        GetTestById = 8,
        Disconnecting = 9,
        GetMyStatistics = 10,
        GetMyTests = 11,
        DeleteTest = 12,
        EditingTest = 13,
        GetTestStatistics = 14,
    }
}
