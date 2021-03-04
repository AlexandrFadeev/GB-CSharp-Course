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

        [TestCase(2)]
        public void RemoveNode_PassingTest(int removeIndex)
        {
            var nodeToRemove = _nodes[removeIndex];
            _linkedList.RemoveNode(nodeToRemove);

            var expectedLinkedList = DoublyLinkedListWithNodesAndRemovedIndex(_nodes, removeIndex);
            
            Assert.AreEqual(expectedLinkedList, _linkedList);
        }
        
        private DoublyLinkedList DoublyListWithNodes(IEnumerable<Node> nodes)
        {
            var linkedList = new DoublyLinkedList();

            foreach (var node in nodes)
            {
                linkedList.AddNode(node);
            }

            return linkedList;
        }

        private DoublyLinkedList DoublyLinkedListWithNodesAndRemovedIndex(IEnumerable<Node> nodes, int removeIndex)
        {
            var linkedList = new DoublyLinkedList();
            var index = 0;

            while (index < nodes.Count() - 1)
            {
                if (index == removeIndex)
                {
                    index++;
                    continue;
                }
                
                linkedList.AddNode(index);
                index++;
            }

            return linkedList;
        }
    }
}