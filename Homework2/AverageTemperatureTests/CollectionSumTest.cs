using System;
using AverageTemperature.model;
using NUnit.Framework;

namespace AverageTemperatureTests
{
    public class CollectionSumTest
    {
        private int[] _numbers;
        private AverageCalculator _averageCalculator;
        private AverageCalculator _emptyAverageCalculator;
        
        [SetUp] 
        public void Setup()
        {
            _numbers = new [] {34, 21};
            _averageCalculator = new AverageCalculator(_numbers);
            _emptyAverageCalculator = new AverageCalculator(new int[] {});
        }
        
        [Test]
        public void PassingCollectionSumTest()
        {
            int expectedResult = 55;
            
            Assert.AreEqual(expectedResult, _averageCalculator.CollectionSum());
        }

        [Test]
        public void FailingCollectionSumTest()
        {
            int expectedResult = 0;
            Assert.AreNotEqual(expectedResult, _averageCalculator.CollectionSum());
        }

        [Test]
        public void ArgumentExceptionEmptyArrayInitializationTest()
        {
            var exception = Assert.Throws<ArgumentException>(() => _emptyAverageCalculator.CollectionSum());
            Assert.AreEqual("collection must not be empty", exception.Message);
        }
    }
}
