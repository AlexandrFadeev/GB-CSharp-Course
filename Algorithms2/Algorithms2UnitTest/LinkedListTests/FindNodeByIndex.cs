using NUnit.Framework;
using Algorithms2.LinkedList;

namespace Algorithms2UnitTest.LinkedListTests
{
    public class FindNodeByIndex
    {
        private DoublyLinkedList _linkedList;
        
        private Node _headNode;
        private Node _secondNode;
        private Node _thirdNode;
        private Node _fourthNode;
        private Node _fifthNode;
        
        [SetUp]
        public void Setup()
        {
            _linkedList = new DoublyLinkedList();

            _headNode = new Node(0);
            _secondNode = new Node(1);
            _thirdNode = new Node(2);
            _fourthNode = new Node(3);
            _fifthNode = new Node(4);
            
            _linkedList.AddNode(_headNode);
            _linkedList.AddNode(_secondNode);
            _linkedList.AddNode(_thirdNode);
            _linkedList.AddNode(_fourthNode);
            _linkedList.AddNode(_fifthNode);
        }

        [Test]
        public void FindNodeByIndex_PassingTest()
        {
            SomeTest(_headNode, 0);
            SomeTest(_secondNode, 1);
            SomeTest(_thirdNode, 2);
            SomeTest(_fourthNode, 3);
            SomeTest(_fifthNode, 4);
        }

        private void SomeTest(Node expectedResult, int index)
        {
            var actualResult = _linkedList.NodeAtIndex(index);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}