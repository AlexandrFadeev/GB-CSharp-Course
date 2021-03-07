using Algorithms3;
using NUnit.Framework;

namespace Algorithms3Test
{
    public class PointDistanceTest
    {
        private Benchmark _benchmark;
        [SetUp]
        public void Setup()
        {
            _benchmark = new Benchmark();
        }

        [TestCase(43d,74d,12d,7d, 73.82411d)]
        [TestCase(8d,5d,0d,12d, 10.63015d)]
        public void PointDistanceDoubleSum_PassingTest(
            double pointOneX, double pointOneY, 
            double pointTwoX, double pointTwoY, 
            double expectedResult)
        {
            var pointOne = new SPoint<double>(pointOneX, pointOneY);
            var pointTwo = new SPoint<double>(pointTwoX, pointTwoY);

            var actualResult = _benchmark.SpointDoubleSum(pointOne, pointTwo);
            
            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.00001));
        }

        [TestCase(43d,74d,12d,7d, 73.82421d)]
        [TestCase(8d,5d,0d,12d, 10.63025d)]
        public void PointDistanceDoubleSum_FailingTest(
            double pointOneX, double pointOneY, 
            double pointTwoX, double pointTwoY, 
            double expectedResult)
        {
            var pointOne = new SPoint<double>(pointOneX, pointOneY);
            var pointTwo = new SPoint<double>(pointTwoX, pointTwoY);

            var actualResult = _benchmark.SpointDoubleSum(pointOne, pointTwo);
            
            Assert.That(actualResult, Is.Not.EqualTo(expectedResult).Within(0.00001));
        }

        [TestCase(43f,74f,12f,7f, 73.82411f)]
        [TestCase(8f,5f,0f,12f, 10.63015f)]
        public void PointDistanceFloat_PassingTest(
            float pointOneX, float pointOneY, 
            float pointTwoX, float pointTwoY, 
            float expectedResult
            )
        {
            var pointOne = new SPoint<float>(pointOneX, pointOneY);
            var pointTwo = new SPoint<float>(pointTwoX, pointTwoY);

            var actualResult = _benchmark.SPointFloatSum(pointOne, pointTwo);
            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.00001));
        }
        
        [TestCase(43f,74f,12f,7f, 73.82421f)]
        [TestCase(8f,5f,0f,12f, 10.63025f)]
        public void PointDistanceDoubleSum_FailingTest(
            float pointOneX, float pointOneY, 
            float pointTwoX, float pointTwoY, 
            float expectedResult)
        {
            var pointOne = new SPoint<float>(pointOneX, pointOneY);
            var pointTwo = new SPoint<float>(pointTwoX, pointTwoY);

            var actualResult = _benchmark.SPointFloatSum(pointOne, pointTwo);
            
            Assert.That(actualResult, Is.Not.EqualTo(expectedResult).Within(0.00001));
        }
    }
}