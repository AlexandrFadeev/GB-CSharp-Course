using NUnit.Framework;
using Algorithms2.LinkedList;

namespace Algorithms2UnitTest.LinkedListTests
{
    public class GetCountTest
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

        [TestCase(5)]
        public void GetCont_PassingTest(int expectedResult)
        {
            var actualResult = _linkedList.GetCount();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(4)]
        public void GetCount_FailingTest(int expectedResult)
        {
            var actualResult = _linkedList.GetCount();
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetCount_OnRemoveNode_PassingTest()
        {
            _linkedList.RemoveFirstNode();
            var expectedResult = 4;
            var actualResult = _linkedList.GetCount();
            Assert.AreEqual(expectedResult, actualResult);
            
            _linkedList.RemoveNode(_thirdNode);
            expectedResult--;
            actualResult = _linkedList.GetCount();
            Assert.AreEqual(expectedResult, actualResult);

            _linkedList.RemoveLastNode();
            expectedResult--;
            actualResult = _linkedList.GetCount();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetCount_OnRemoveNode_FailingTest()
        {
            _linkedList.RemoveFirstNode();
            var expectedResult = 3;
            var actualResult = _linkedList.GetCount();
            Assert.AreNotEqual(expectedResult, actualResult);
            
            _linkedList.RemoveNode(_thirdNode);
            expectedResult = 4;
            actualResult = _linkedList.GetCount();
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsEmpty_PassingTest()
        {
            var linkedList = new DoublyLinkedList();
            var expectedResult = 0;
            var actualResult = linkedList.GetCount();
            
            Assert.AreEqual(expectedResult, actualResult);
            Assert.IsTrue(linkedList.IsEmpty);
        }

        [Test]
        public void IsEmpty_FailingTest()
        {
            var linkedList = new DoublyLinkedList();
            linkedList.AddNode(_headNode);
            
            var expectedResult = 0;
            var actualResult = linkedList.GetCount();
            Assert.AreNotEqual(expectedResult, actualResult);
            Assert.IsFalse(linkedList.IsEmpty);
        }

        [Test]
        public void GetCount_OnAddNode_PassingTest()
        {
            var linkedList = new DoublyLinkedList();
            linkedList.AddNode(_headNode);

            var expectedResult = 1;
            var actualResult = linkedList.GetCount();
            Assert.AreEqual(expectedResult, actualResult);
            
            linkedList.AddNode(_secondNode);
            expectedResult++;
            actualResult = linkedList.GetCount();
            Assert.AreEqual(expectedResult, actualResult);
            
            linkedList.AddNodeAfter(_headNode, 34);
            expectedResult++;
            actualResult = linkedList.GetCount();
            Assert.AreEqual(expectedResult, actualResult);
            
            linkedList.AddNodeAfter(_secondNode, 66);
            expectedResult++;
            actualResult = linkedList.GetCount();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetCount_OnAddNode_FailingTest()
        {
            var linkedList = new DoublyLinkedList();
            linkedList.AddNode(_headNode);

            var expectedResult = 2;
            var actualResult = linkedList.GetCount();
            Assert.AreNotEqual(expectedResult, actualResult);
            
            linkedList.AddNode(_secondNode);
            expectedResult = 1;
            actualResult = linkedList.GetCount();
            Assert.AreNotEqual(expectedResult, actualResult);
            
            linkedList.AddNodeAfter(_headNode, 34);
            expectedResult = 4;
            actualResult = linkedList.GetCount();
            Assert.AreNotEqual(expectedResult, actualResult);
        }
    }
}