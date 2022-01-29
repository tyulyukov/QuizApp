using QuizLibrary;
using System;

namespace ClientServer
{
    [Serializable]
    public class Response
    {
        public bool Result { get; private set; }
        public String Message { get; private set; }
        public object Parameter { get; private set; }

        public Response(String message, bool result)
        {
            Message = message;
            Result = result;
        }

        public Response(String message, TestsCollection testCollection)
        {
            Message = message;
            Parameter = testCollection;
        }

        public Response(String message, Test test)
        {
            Message = message;
            Parameter = test;
        }

        public Response(String message, StatisticsCollection statisticsCollection)
        {
            Message = message;
            Parameter = statisticsCollection;
        }
    }
}
