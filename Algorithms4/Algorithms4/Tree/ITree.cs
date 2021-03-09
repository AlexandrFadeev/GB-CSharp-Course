namespace Algorithms4.Tree
{
    public interface ITree<T>
    {
        TreeNode<T> GetRoot();
        void AddItem(int value);
        void RemoveItem(int value);
        TreeNode<T> GetNodeByValue(T value);
        void PrintTree();
    }
}