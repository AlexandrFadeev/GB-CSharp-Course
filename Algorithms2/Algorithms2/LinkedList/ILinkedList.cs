namespace Algorithms2.LinkedList
{
    #nullable enable
    public interface ILinkedList
    {
        int GetCount();
        void AddNode(int value);
        void AddNodeAfter(Node node, int value);
        void RemoveNode(int index);
        void RemoveNode(Node node);
        Node? FindNode(int searchValue);
        Node? NodeAtIndex(int index);
        bool Contains(Node node);
    }
}