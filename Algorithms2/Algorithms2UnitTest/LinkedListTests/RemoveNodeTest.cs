using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Algorithms2.LinkedList;

namespace Algorithms2UnitTest.LinkedListTests
{
    public class RemoveNodeTest
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
        public void RemoveHeadNode_PassingTest()
        {
            var head = _linkedList.HeadNode;
            var expectedResult = head?.Next;
            var actualResult = _linkedList.RemoveFirstNode();
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RemoveHeadNode_FailingTest()
        {
            var head = _linkedList.HeadNode;
            var expectedResult = head?.Next.Next;
            var actualResult = _linkedList.RemoveFirstNode();
            
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [Test]
        public void RemoveHead_FromSingleElementList_PassingTest()
        {
            var headNode = new Node(0);
            var linkedList = new DoublyLinkedList();
            
            linkedList.AddNode(headNode);

            var actualResult = linkedList.RemoveFirstNode();
            Assert.IsNull(actualResult);
        }

        [Test]
        public void RemoveHead_FromSingleElementList_FailingTest()
        {
            var headNode = new Node(0);
            var linkedList = new DoublyLinkedList();
            
            linkedList.AddNode(headNode);

            var actualResult = linkedList.RemoveFirstNode();
            Assert.AreNotEqual(headNode, actualResult);
        }

        [Test]
        public void RemoveTail_PassingTest()
        {
            var lastIndex = _nodes.Length - 1;
            var tail = _nodes[lastIndex];
            var expectedResult = tail.Previous;

            var actualResult = _linkedList.RemoveLastNode();
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RemoveTail_FailingTest()
        {
            var lastIndex = _nodes.Length - 1;
            var tail = _nodes[lastIndex];

            var actualResult = _linkedList.RemoveLastNode();
            
            Assert.AreNotEqual(tail, actualResult);
        }

        [Test]
        public void RemoveTail_FromSingleElementList_PassingTest()
        {
            var node = new Node(0);
            var linkedList = new DoublyLinkedList();
            linkedList.AddNode(node);

            var actualResult = linkedList.RemoveLastNode();
            
            Assert.IsNull(actualResult);
        }

        [Test]
        public void RemoveTail_FromSingleElementList_FailingTest()
        {
            var node = new Node(0);
            var linkedList = new DoublyLinkedList();
            linkedList.AddNode(node);

            var actualResult = linkedList.RemoveLastNode();
            
            Assert.AreNotEqual(node, actualResult);
        }

        [TestCaseSource()]
        public void RemoveNode_PassingTest(int removeIndex, Node expectedPreviousNode, Node expectedNextNode)
        {
            var nodeToRemove = _nodes[removeIndex];
            
            _linkedList.RemoveNode(nodeToRemove);
            
            Assert.AreEqual(_secondNode.Next, _fourthNode);
            Assert.AreEqual(_fourthNode.Previous, _secondNode);
            Assert.IsNull(nodeToRemove.Previous);
            Assert.IsNull(nodeToRemove.Next);
        }

        private object[] RemoveNodeCases =
        {
            new object[] { 2, _secondNode }
        };
    }
}