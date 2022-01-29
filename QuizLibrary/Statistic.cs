using System;
using System.Collections.Generic;

namespace QuizLibrary
{
    [Serializable]
    public class Statistic
    {
        public DateTime PassDate { get; private set; }
        public TimeSpan PassTime { get; private set; }
        public int Score { get; private set; }
        public int MaxScore { get; private set; }
        public String TestName { get; private set; }
        public String UserNickname  { get; private set; }

        public Statistic(DateTime passDate, TimeSpan passTime, int score, int maxScore, String testName, String user)
        {
            PassDate = passDate;
            PassTime = passTime;
            Score = score;
            MaxScore = maxScore;
            TestName = testName;
            UserNickname = user;
        }
    }

    [Serializable]
    public class StatisticsCollection
    {
        public IReadOnlyList<Statistic> Statistics => statistics;

        private List<Statistic> statistics = new List<Statistic>();

        public StatisticsCollection(params Statistic[] newStatistics)
        {
            statistics.AddRange(newStatistics);
        }

        public StatisticsCollection(IEnumerable<Statistic> newStatistics)
        {
            statistics.AddRange(newStatistics);
        }
    }
}
