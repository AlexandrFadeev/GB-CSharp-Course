using System;

namespace Algorithms2.Linked_List
{
    public class DoublyLinkedList : ILinkedList
    {
        public bool IsEmpty => _listCounter == 0;
        
        private Node _head;
        private Node _tail;
        private int _listCounter;
        
        /// <summary>
        /// This method iterates through list and calculates count of all nodes
        /// </summary>
        /// <returns>int value of list all nodes count</returns>
        public int GetCount()
        {
            return _listCounter;
        }

        /// <summary>
        /// Add new node to the end of list
        /// </summary>
        /// <param name="value">associated data with this node </param>
        public void AddNode(int value)
        {
            if (_head == null)
            {
                _head = new Node(value);
                _listCounter++;
                return;
            }

            var tempNode = _head;
            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
            }

            var newNode = new Node(value);
            tempNode.Next = newNode;
            newNode.Previous = tempNode;
            
            _tail = newNode;
            _listCounter++;
        }

        public void AddNode(Node node)
        {
            if (_head == null)
            {
                _head = node;
                _listCounter++;
                return;
            }

            var tempNode = _head;
            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
            }

            node.Previous = tempNode;
            tempNode.Next = node;
            _listCounter++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node(value) {Next = node.Next, Previous = node};
            node.Next = newNode;
            _listCounter++;
        }

        public void RemoveNode(int index)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new System.NotImplementedException();
        }

        // Here we probably need to return an array of nodes, cos we can find more then one node with same value
        public Node FindNode(int searchValue)
        {
            if (_head == null)
            {
                return null;
            }
            var tempNode = _head;

            while (tempNode != null)
            {
                if (tempNode.Data == searchValue)
                {
                    return tempNode;
                }

                tempNode = tempNode.Next;
            }
            
            return null;
        }

        public void Print()
        {
            if (_head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            var tempNode = _head;
            while (tempNode != null)
            {
                Console.Write($"[{tempNode.Data}] -> ");
                tempNode = tempNode.Next;
            }
        }
    }
}