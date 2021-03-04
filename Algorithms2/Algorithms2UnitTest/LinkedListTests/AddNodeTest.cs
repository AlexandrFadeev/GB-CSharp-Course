using NUnit.Framework;
using Algorithms2.LinkedList;

namespace Algorithms2UnitTest.LinkedListTests
{
    public class AddNodeTest
    {
        private DoublyLinkedList _linkedList;
        private static Node _headNode;
        private static Node _secondNode;
        private static Node _thirdNode;
        private static Node _fourthNode;
        private static Node _fifthNode;
        
        [SetUp]
        public void Setup()
        {
            _linkedList = new DoublyLinkedList();

            _headNode = new Node(0);
            _secondNode = new Node(1);
            _thirdNode = new Node(2);
            _fourthNode = new Node(3);
            _fifthNode = new Node(4);
        }

        [Test]
        public void AddNode_PassingTest()
        {
            _linkedList.AddNode(_headNode);
            
            Assert.NotNull(_linkedList.HeadNode);
            Assert.IsNull(_headNode.Previous);
            Assert.IsNull(_headNode.Next);
            
            _linkedList.AddNode(_secondNode);
            Assert.AreEqual(_headNode.Next, _secondNode);
            Assert.AreEqual(_secondNode.Previous, _headNode);
            Assert.IsNull(_secondNode.Next);
            
            _linkedList.AddNode(_thirdNode);
            Assert.AreEqual(_secondNode.Next, _thirdNode);
            Assert.AreEqual(_secondNode.Previous, _headNode);
            Assert.AreEqual(_thirdNode.Previous, _secondNode);
            Assert.IsNull(_thirdNode.Next);
        }

        [Test]
        public void AddNode_FailingTest()
        {
            _linkedList.AddNode(_headNode);
            _linkedList.AddNode(_secondNode);
            
            Assert.AreNotEqual(_headNode.Next, _thirdNode);
            Assert.IsNotNull(_secondNode.Previous);
        }

        [Test]
        public void AddNodeAfter_PassingTest()
        {
            _linkedList.AddNode(_headNode);
            _linkedList.AddNode(_secondNode);
            
            Assert.AreEqual(_headNode.Next, _secondNode);
            Assert.AreEqual(_secondNode.Previous, _headNode);
            
            _linkedList.AddNodeAfter(_headNode, 10);
            Assert.AreEqual(_headNode.Next.Data, 10);
            Assert.AreEqual(_secondNode.Previous.Data, 10);
            
            _linkedList.AddNodeAfter(_headNode, 20);
            Assert.AreEqual(_headNode.Next.Data, 20);
            Assert.AreEqual(_secondNode.Previous.Data, 10);
        }

        [Test]
        public void AddNodeAfter_FailingTest()
        {
            _linkedList.AddNode(_headNode);
            _linkedList.AddNode(_secondNode);
            
            Assert.AreNotEqual(_headNode.Next, _thirdNode);
            Assert.AreNotEqual(_secondNode.Previous, _fourthNode);
            
            _linkedList.AddNodeAfter(_headNode, 10);
            Assert.AreNotEqual(_headNode.Next.Data, 1);
            Assert.AreNotEqual(_secondNode.Previous.Data, 0);
            
            _linkedList.AddNodeAfter(_headNode, 20);
            Assert.AreNotEqual(_headNode.Next.Data, 10);
            Assert.AreNotEqual(_secondNode.Previous.Data, 20);
        }
    }
}