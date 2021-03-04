#nullable enable
using System;
using System.Text;

namespace Algorithms2.LinkedList
{
    public class DoublyLinkedList : ILinkedList
    {
        public bool IsEmpty => _listCounter == 0;

        public Node? HeadNode => _head;

        private Node? _head;
        private Node? _tail;
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
            _tail = node;
            
            _listCounter++;
        }

        // [1] <-> [2] <-> [3] <->
        // [1] <-> [2] <-> x <-> [3] <->
        // [1] <-> [2] <-> [3] <-> x <->
        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node(value);
            var nextNode = node.Next;

            _listCounter++;
            
            if (nextNode == null)
            {
                newNode.Previous = node;
                return;
            }
            
            nextNode.Previous = newNode;
            node.Next = newNode;

            newNode.Previous = node;
            newNode.Next = nextNode;
        }

        public void RemoveNode(int index)
        {
            if (_head == null)
            {
                return;
            }

            if (!IndexIsInBoundsOfList(index))
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                RemoveFirstNode();
                return;
            }

            var currentIndex = 1;
            var tempNode = _head.Next;

            while (tempNode != null)
            {
                if (index == currentIndex)
                {
                    
                }
            }
        }
        
        /// <summary>
        /// Remove given node from list.
        /// </summary>
        /// <param name="node">Node that need to be removed</param>
        public void RemoveNode(Node? node)
        {
            if (node == null)
            {
                return;
            }

            if (!Contains(node))
            {
                throw new NodeNotFoundException();
            }

            if (node == _head)
            {
                RemoveFirstNode();
                return;
            }
            
            if (node == _tail)
            {
                RemoveLastNode();
                return;
            }
            
            // <- [0] <-> [1] <-> [2] ->
            // <- [0] ->
            
            var previousNode = node.Previous;
            var nextNode = node.Next;

            previousNode.Next = nextNode;
            nextNode.Previous = previousNode;

            node.Previous = null;
            node.Next = null;
            
            _listCounter--;
        }

        /// <summary>
        /// Remove first node from list. If list has only one node, method will remove it and return null
        /// </summary>
        /// <returns>Current head node of list. In case if list is empty, return null</returns>
        public Node? RemoveFirstNode()
        {
            if (_head == null)
            {
                return null;
            }

            _listCounter--;
            var nextNode = _head.Next;
            if (nextNode == null)
            {
                _head = null;
                return null;
            }
            
            nextNode.Previous = null;
            _head = nextNode;
            
            return _head;
        }

        /// <summary>
        /// Remove last node from list. If list has only one node, method will remove it and return null
        /// </summary>
        /// <returns>Current tail node of list. In case if list is empty, return null</returns>
        public Node? RemoveLastNode()
        {
            if (_tail == null)
            {
                return null;
            }

            _listCounter--;
            var previousNode = _tail.Previous;
            if (previousNode == null)
            {
                _tail = null;
                return null;
            }

            previousNode.Next = null;
            _tail = previousNode;

            return _tail;
        }

        // Here we probably need to return an array of nodes, cos we can find more then one node with same value
        public Node? FindNode(int searchValue)
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
        
        public Node? NodeAtIndex(int index)
        {
            if (!IndexIsInBoundsOfList(index))
            {
                throw new IndexOutOfRangeException();
            }

            if (_head == null)
            {
                return null;
            }

            var currentIndex = 0;
            var tempNode = _head;

            while (tempNode != null)
            {
                if (currentIndex == index)
                {
                    return tempNode;
                }

                currentIndex++;
                tempNode = tempNode.Next;
            }

            return null;
        }

        public bool Contains(Node node)
        {
            if (_head == null)
            {
                return false;
            }

            var tempNode = _head;

            while (tempNode != null)
            {
                if (node.Equals(tempNode))
                {
                    return true;
                }
                
                tempNode = tempNode.Next;
            }

            return false;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            
            if (_head == null)
            {
                return stringBuilder.Append("List is empty").ToString();
            }

            var tempNode = _head;
            while (tempNode != null)
            {
                // Console.Write($"[{tempNode.Data}] -> ");
                stringBuilder.Append($"[{tempNode.Data}] -> ");
                tempNode = tempNode.Next;
            }

            return stringBuilder.ToString();
        }

        private bool IndexIsInBoundsOfList(int index)
        {
            return index >= 0 && index < _listCounter;
        }
    }
}