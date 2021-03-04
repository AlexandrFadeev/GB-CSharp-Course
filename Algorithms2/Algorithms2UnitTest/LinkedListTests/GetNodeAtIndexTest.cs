using System;
using Algorithms2.LinkedList;
using NUnit.Framework;

namespace Algorithms2UnitTest.LinkedListTests
{
    public class GetNodeAtIndexTest
    {

        private DoublyLinkedList _linkedList;
        private Node[] _nodes;
        
        [SetUp]
        public void Setup()
        {
            _nodes = new[]
            {
                new Node(0),
                new Node(1),
                new Node(2),
                new Node(3),
                new Node(4)
            };

            _linkedList = DoublyListWithNodes(_nodes);
        }

        [Test]
        public void GetNodeAtIndex_PassingTest()
        {
            var expectedResult = _nodes[0];
            var actualResult = _linkedList.NodeAtIndex(0);
            Assert.AreEqual(expectedResult, actualResult);

            expectedResult = _nodes[1];
            actualResult = _linkedList.NodeAtIndex(1);
            Assert.AreEqual(expectedResult, actualResult);

            var lastIndex = _nodes.Length - 1;
            expectedResult = _nodes[lastIndex];
            actualResult = _linkedList.NodeAtIndex(lastIndex);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetNodeAtIndex_FailingTest()
        {
            var expectedResult = _nodes[0];
            var actualResult = _linkedList.NodeAtIndex(1);
            Assert.AreNotEqual(expectedResult, actualResult);

            expectedResult = _nodes[1];
            actualResult = _linkedList.NodeAtIndex(0);
            Assert.AreNotEqual(expectedResult, actualResult);

            expectedResult = _nodes[2];
            actualResult = _linkedList.NodeAtIndex(3);
            Assert.AreNotEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void GetNodeAtIndex_OutOfBoundsException_PassingTest()
        {
            Assert.Throws<IndexOutOfRangeException>(() => _linkedList.NodeAtIndex(-1));
            Assert.Throws<IndexOutOfRangeException>(() => _linkedList.NodeAtIndex(_nodes.Length));
            Assert.Throws<IndexOutOfRangeException>(() => _linkedList.NodeAtIndex(_nodes.Length + 2));
        }
        
        [Test]
        public void GetNodeAtIndex_OutOfBoundsException_FailingTest()
        {
            var lastIndex = _nodes.Length - 1;
            
            Assert.DoesNotThrow(() => _linkedList.NodeAtIndex(0));
            Assert.DoesNotThrow(() => _linkedList.NodeAtIndex(2));
            Assert.DoesNotThrow(() => _linkedList.NodeAtIndex(lastIndex));
        }

        private DoublyLinkedList DoublyListWithNodes(Node[] nodes)
        {
            var linkedList = new DoublyLinkedList();

            foreach (var node in nodes)
            {
                linkedList.AddNode(node);
            }

            return linkedList;
        }
    }
}