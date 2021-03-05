using NUnit.Framework;
using Algorithms2.LinkedList;

namespace Algorithms2UnitTest.LinkedListTests
{
    public class FindNodeByValueTest
    {
        private DoublyLinkedList _linkedList;
        private Node[] _nodes;
        
        private Node _headNode;
        private Node _secondNode;
        private Node _thirdNode;
        private Node _fourthNode;
        private Node _fifthNode;
        
        [SetUp]
        public void Setup()
        {
            _headNode = new Node(0);
            _secondNode = new Node(1);
            _thirdNode = new Node(2);
            _fourthNode = new Node(3);
            _fifthNode = new Node(4);

            _nodes = new[]
            {
                _headNode,
                _secondNode,
                _thirdNode,
                _fourthNode,
                _fifthNode
            };
            
            _linkedList = new DoublyLinkedList();
            
            _linkedList.AddNode(_headNode);
            _linkedList.AddNode(_secondNode);
            _linkedList.AddNode(_thirdNode);
            _linkedList.AddNode(_fourthNode);
            _linkedList.AddNode(_fifthNode);
        }

        [Test]
        public void FindNodeByValue_PassingTest()
        {
            var expectedResult = _headNode;
            var actualResult = _linkedList.FindNode(0);
            Assert.AreEqual(expectedResult, actualResult);

            expectedResult = _secondNode;
            actualResult = _linkedList.FindNode(1);
            Assert.AreEqual(expectedResult, actualResult);
            
            expectedResult = _thirdNode;
            actualResult = _linkedList.FindNode(2);
            Assert.AreEqual(expectedResult, actualResult);
            
            expectedResult = _fifthNode;
            actualResult = _linkedList.FindNode(4);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FindNodeByValue_FailingTest()
        {
            var expectedResult = _headNode;
            var actualResult = _linkedList.FindNode(1);
            Assert.AreNotEqual(expectedResult, actualResult);
            
            Assert.IsNull(_linkedList.FindNode(66));
        }
    }
}