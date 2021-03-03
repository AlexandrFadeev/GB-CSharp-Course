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