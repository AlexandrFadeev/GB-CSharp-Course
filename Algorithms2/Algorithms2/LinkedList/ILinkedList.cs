namespace Algorithms2.LinkedList
{
    public interface ILinkedList
    {
        int GetCount();
        void AddNode(int value);
        void AddNodeAfter(Node node, int value);
        void RemoveNode(int index);
        void RemoveNode(Node node);
        Node FindNode(int searchValue);
        bool Contains(Node node);
    }
}