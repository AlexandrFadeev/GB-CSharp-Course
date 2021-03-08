using System.Collections.Generic;

namespace Algorithms4.Tree
{
    public class TreeHelper
    {
        public static NodeInfo<int>[] GetTreeInLine(ITree<int> tree)
        {
            var bufer = new Queue<NodeInfo<int>>();
            var returnArray = new List<NodeInfo<int>>();
            var root = new NodeInfo<int>() { Node = tree.GetRoot() };
            bufer.Enqueue(root);

            while (bufer.Count != 0)
            {
                var element = bufer.Dequeue();
                returnArray.Add(element);

                var depth = element.Depth + 1;

                if (element.Node.LeftChild != null)
                {
                    var left = new NodeInfo<int>()
                    {
                        Node = element.Node.LeftChild,
                        Depth = depth,
                    };
                    bufer.Enqueue(left);
                }
                if (element.Node.RightChild != null)
                {
                    var right = new NodeInfo<int>()
                    {
                        Node = element.Node.RightChild,
                        Depth = depth,
                    };
                    bufer.Enqueue(right);
                }
            }
            
            return returnArray.ToArray();
        }
    }
}