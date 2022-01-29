using System;
using System.Collections.Generic;

namespace QuizLibrary
{
    [Serializable]
    public class TestsCollection
    {
        public IReadOnlyList<Test> Tests => tests;

        private List<Test> tests = new List<Test>();

        public TestsCollection(params Test[] newTests)
        {
            tests.AddRange(newTests);
        }

        public TestsCollection(IEnumerable<Test> newTests)
        {
            tests.AddRange(newTests);
        } 
    }
}
