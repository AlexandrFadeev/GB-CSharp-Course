using NUnit.Framework;
using Algorithms1;

namespace Algorithms1UnitTest
{
    
    public class FibonacciTest
    {
        private Fibonacci _fibonacci;
        
        [SetUp]
        public void Setup()
        {
            _fibonacci = new Fibonacci();
        }

        [TestCase(1, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 2)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(8, ExpectedResult = 21)]
        [TestCase(12, ExpectedResult = 144)]
        [TestCase(21, ExpectedResult = 10946)]
        [TestCase(33, ExpectedResult = 3524578)]
        public long RecursivePassingTest(int number)
        {
            return _fibonacci.RecursiveFibonacci(number);
        }

        [TestCase(1, 2)]
        [TestCase(3, 3)]
        [TestCase(5, 6)]
        [TestCase(8, 20)]
        [TestCase(8, 22)]
        [TestCase(12, 143)]
        public void RecursiveFailingTest(int number, long expected)
        {
            var result = _fibonacci.RecursiveFibonacci(number);
            Assert.AreNotEqual(result, expected);
        }

        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 2)]
        [TestCase(8, ExpectedResult = 21)]
        [TestCase(12, ExpectedResult = 144)]
        [TestCase(19, ExpectedResult = 4181)]
        [TestCase(30, ExpectedResult = 832040)]
        [TestCase(39, ExpectedResult = 63245986)]
        [TestCase(43, ExpectedResult = 433494437)]
        public long FibonacciLoopPassingTest(int number)
        {
            return _fibonacci.FibonacciLoop(number);
        }

        [TestCase(3, 1)]
        [TestCase(3, 3)]
        [TestCase(19, 4180)]
        [TestCase(19, 4182)]
        [TestCase(43, 433494436)]
        [TestCase(43, 433494438)]
        public void FibonacciLoopFailingTest(int number, long expected)
        {
            var result = _fibonacci.FibonacciLoop(number);
            Assert.AreNotEqual(result, expected);
        }
    }
}