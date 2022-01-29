using System;
using System.Collections.Generic;

namespace QuizLibrary
{
    [Serializable]
    public class Test
    {
        public Guid Id;
        public String Author;
        public String Name;
        public List<Question> Questions = new List<Question>();
    }

    [Serializable]
    public class Question
    {
        public String Name;
        public List<AnswerOptions> AnswersOptions = new List<AnswerOptions>();
        public String Base64ImageRepresentation;
    }

    [Serializable]
    public class AnswerOptions
    {
        public String Name;
        public bool Right;
    }

    [Serializable]
    public class AnswersDictionary
    {
        public Guid TestId;
        public TimeSpan PassingTime;
        public DateTime PassDate;
        public IReadOnlyDictionary<int, Dictionary<int, bool>> Answers => answers;

        private Dictionary<int, Dictionary<int, bool>> answers = new Dictionary<int, Dictionary<int, bool>>();

        public AnswersDictionary(Guid testId, TimeSpan passingTime, DateTime passDate, params KeyValuePair<int, Dictionary<int, bool>>[] newAnswers)
        {
            TestId = testId;
            PassingTime = passingTime;
            PassDate = passDate;

            foreach (var keyAnswer in newAnswers)
                answers.Add(keyAnswer.Key, keyAnswer.Value);
        }

        public AnswersDictionary(Guid testId, TimeSpan passingTime, DateTime passDate, Dictionary<int, Dictionary<int, bool>> newAnswers)
        {
            TestId = testId;
            PassingTime = passingTime;
            PassDate = passDate;

            foreach (var keyAnswer in newAnswers)
                answers.Add(keyAnswer.Key, keyAnswer.Value);
        }
    }
}
