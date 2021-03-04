using System.Collections;
using NUnit.Framework;
using Algorithms2.LinkedList;

namespace Algorithms2UnitTest.LinkedListTests
{
    public class ContainsNodeTest
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
        public void ContainsNode_PassingTest()
        {
            Assert.IsTrue(_linkedList.Contains(_headNode));
            Assert.IsTrue(_linkedList.Contains(_thirdNode));
            Assert.IsTrue(_linkedList.Contains(_fifthNode));
        }

        [Test]
        public void ContainsNode_FailingNode()
        {
            var nonExistingNode = new Node(0);
            Assert.IsFalse(_linkedList.Contains(nonExistingNode));
            Assert.IsFalse(_linkedList.Contains(new Node(0)));
        }
    }
}