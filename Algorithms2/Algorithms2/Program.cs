
using System;
using Algorithms2.Linked_List;

namespace Algorithms2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList();
            var firstNode = new Node(0);
            var secondNode = new Node(1);
            var thirdNode = new Node(2);
            var middleNode = new Node(3);

            list.AddNode(firstNode);
            list.AddNode(secondNode);
            list.AddNode(thirdNode);
            list.AddNodeAfter(secondNode, 4);
            list.AddNode(middleNode);

            list.Print();
            Console.WriteLine($"list count {list.GetCount()}");
        }
    }
}