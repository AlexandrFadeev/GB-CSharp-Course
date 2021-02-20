using NUnit.Framework;
using Algorithms1;

namespace Algorithms1UnitTest
{
    public class PrimeNumberTest
    {

        private PrimeNumber _primeNumber;
        
        [SetUp]
        public void Setup()
        {
            _primeNumber = new PrimeNumber();
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(53)]
        [TestCase(139)]
        [TestCase(199)]
        public void PassingTest(int number)
        {
            Assert.IsTrue(_primeNumber.IsPrimeNumber(number));
        }

        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(24)]
        [TestCase(30)]
        [TestCase(52)]
        [TestCase(34)]
        [TestCase(72)]
        [TestCase(140)]
        public void FailingTest(int number)
        {
            Assert.IsFalse(_primeNumber.IsPrimeNumber(number));
        }
    }
}