using AverageTemperature.model;
using NUnit.Framework;

namespace AverageTemperatureTests
{
    public class AverageTest
    {
        private AverageCalculator _averageCalculator;
        private int[] _numbers;
        
        [SetUp] 
        public void Setup()
        {
            _numbers = new [] {34, 21};
            _averageCalculator = new AverageCalculator(_numbers);
        }

        [Test]
        public void PassingAverageTest()
        {
            double expectedResult = 27.5;
            
            Assert.AreEqual(expectedResult, _averageCalculator.CalculatedAverage());
        }

        [Test]
        public void FailingEdgeDownAverageTest()
        {
            double result = 27.4;
            Assert.AreNotEqual(result, _averageCalculator.CalculatedAverage());
        }

        [Test]
        public void FailingEdgeUpAverageTest()
        {
            double result = 27.6;
            Assert.AreNotEqual(result, _averageCalculator.CalculatedAverage());
        }
    }
}