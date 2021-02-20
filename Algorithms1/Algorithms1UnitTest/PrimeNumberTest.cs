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

        [Test]
        public void Test1()
        {
            
        }

        [Test]
        public void PassingTest()
        {
            Assert.IsTrue(_primeNumber.IsPrimeNumber(1));
            Assert.IsTrue(_primeNumber.IsPrimeNumber(2));
            Assert.IsTrue(_primeNumber.IsPrimeNumber(3));
            Assert.IsTrue(_primeNumber.IsPrimeNumber(5));
            Assert.IsTrue(_primeNumber.IsPrimeNumber(7));
            Assert.IsTrue(_primeNumber.IsPrimeNumber(53));
            Assert.IsTrue(_primeNumber.IsPrimeNumber(59));
            Assert.IsTrue(_primeNumber.IsPrimeNumber(139));
            Assert.IsTrue(_primeNumber.IsPrimeNumber(199));
        }

        [Test]
        public void FailingTest()
        {
            Assert.IsFalse(_primeNumber.IsPrimeNumber(4));
            Assert.IsFalse(_primeNumber.IsPrimeNumber(6));
            Assert.IsFalse(_primeNumber.IsPrimeNumber(8));
            Assert.IsFalse(_primeNumber.IsPrimeNumber(40));
            Assert.IsFalse(_primeNumber.IsPrimeNumber(52));
            Assert.IsFalse(_primeNumber.IsPrimeNumber(54));
            Assert.IsFalse(_primeNumber.IsPrimeNumber(72));
            Assert.IsFalse(_primeNumber.IsPrimeNumber(138));
            Assert.IsFalse(_primeNumber.IsPrimeNumber(140));
        }
    }
}