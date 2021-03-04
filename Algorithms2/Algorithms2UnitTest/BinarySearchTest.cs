using System.Collections.Generic;
using NUnit.Framework;
using Algorithms2;

namespace Algorithms2UnitTest
{
    public class BinarySearchTest
    {
        private BinarySearch _binarySearch;
        private List<int> _numbers;
        
        [SetUp]
        public void Setup()
        {
            _binarySearch = new BinarySearch();
            _numbers = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                _numbers.Add(i);
            }
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(45, ExpectedResult = 45)]
        [TestCase(143, ExpectedResult = 143)]
        [TestCase(666, ExpectedResult = 666)]
        [TestCase(999, ExpectedResult = 999)]
        public int? FoundElementPassingTest(int searchItem)
        {
            return _binarySearch.SearchElementFromCollection(_numbers, searchItem);
        }

        [TestCase(0, -1)]
        [TestCase(0, 1)]
        [TestCase(54, 53)]
        [TestCase(54, 55)]
        [TestCase(666, 665)]
        [TestCase(666, 667)]
        [TestCase(999, 998)]
        [TestCase(999, 1000)]
        public void FoundElementFailingTest(int searchItem, int? result)
        {
            var index = _binarySearch.SearchElementFromCollection(_numbers, searchItem);
            Assert.AreNotEqual(result, index);
        }

        [TestCase(-1, ExpectedResult = null)]
        [TestCase(1000, ExpectedResult = null)]
        public int? NotFoundElementPassingTest(int searchItem)
        {
            return _binarySearch.SearchElementFromCollection(_numbers, searchItem);
        }
        
        [TestCase(-1, 0)]
        [TestCase(1000, 1000)]
        public void NotFoundElementFailingTest(int searchItem, int? result)
        {
            var index = _binarySearch.SearchElementFromCollection(_numbers, searchItem);
            Assert.AreNotEqual(index, result);
        }

        [TestCase(23, ExpectedResult = null)]
        public int? EmptyArrayPassingTest(int searchItem)
        {
            return _binarySearch.SearchElementFromCollection(new List<int>(), searchItem);
        }

        [TestCase(0, 0)]
        [TestCase(100, 100)]
        [TestCase(999, 999)]
        public void EmptyArrayFailingTest(int searchItem, int result)
        {
            var index = _binarySearch.SearchElementFromCollection(new List<int>(), searchItem);
            Assert.AreNotEqual(index, result);
        }
    }
}