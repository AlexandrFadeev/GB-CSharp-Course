using Algorithms4;
using NUnit.Framework;

namespace Algorithms4Test
{
    public class StringCollectionGeneratorTest
    {
        private StringCollectionGenerator _stringCollectionGenerator;
        
        [SetUp]
        public void Setup()
        {
            _stringCollectionGenerator = new StringCollectionGenerator();
        }
        
        [TestCase((uint)0, ExpectedResult = 0)]
        [TestCase((uint)1, ExpectedResult = 1)]
        [TestCase((uint)10, ExpectedResult = 10)]
        [TestCase((uint)100, ExpectedResult = 100)]
        [TestCase((uint)500, ExpectedResult = 500)]
        [TestCase((uint)1000, ExpectedResult = 1000)]
        public int ListLenght_PassingTest(uint arrayLenght)
        {
            var list = _stringCollectionGenerator.GenerateStringsArray(arrayLenght);
            return list.Count;
        }

        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 0)]
        [TestCase((uint)1, 2)]
        [TestCase((uint)50, 49)]
        [TestCase((uint)50, 51)]
        public void ListLenght_FailingTest(uint arrayLenght, int expectedResult)
        {
            var list = _stringCollectionGenerator.GenerateStringsArray(arrayLenght);
            var actualResult = list.Count;
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [Test]
        public void WordLenght_Test()
        {
            var expectedResult = 8;
            var list = _stringCollectionGenerator.GenerateStringsArray(20);

            foreach (var currentString in list)
            {
                Assert.AreEqual(currentString.Length, expectedResult);
            }
        }

        [TestCase("word", ExpectedResult = false)]
        public bool ListContains_PassingTest(string searchString)
        {
            var list = _stringCollectionGenerator.GenerateStringsArray(10000);

            return list.Contains(searchString);
        }
        
        [TestCase("word", true)]
        public void ListContains_FailingTest(string searchString, bool expectedResult)
        {
            var list = _stringCollectionGenerator.GenerateStringsArray(10000);
            var contains = list.Contains(searchString);
            
            Assert.AreNotEqual(expectedResult, contains);
        }
    }
}