using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Algorithms4
{
    public class StringCollectionBenchmark
    {
        private List<string> _stringsList;
        private HashSet<string> _stringsSet;

        public StringCollectionBenchmark()
        {
            var stringsGenerator = new StringCollectionGenerator();
            _stringsList = stringsGenerator.GenerateStringsArray(10000);
            _stringsSet = new HashSet<string>(_stringsList);
        }

        [Benchmark]
        public void TestContainsInArray()
        {
            _stringsList.Contains("word");
        }

        [Benchmark]
        public void TestContainsInSet()
        {
            _stringsSet.Contains("word");
        }
    }
}