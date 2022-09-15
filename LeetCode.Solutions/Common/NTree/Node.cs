using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Common.NTree
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public static class NodeExtensions
    {
        /// TODO: Bug is HERE!
        public static Node ToTree(this int?[] input)
        {
            if (input == null
                || input.Length == 0)
            {
                return null;
            }

            Node root = null;
            Node currentRoot = null;

            // var input = new int?[] { 1, null, 3, 2, 4, null, 5, 6 };
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i].HasValue)
                {
                    var node = new Node(input[i].Value);

                    if (currentRoot == null)
                    {
                        root ??= node;
                        currentRoot = node;
                    }
                    else
                    {
                        currentRoot.children ??= new List<Node>();
                        currentRoot.children.Add(node);
                    }
                }
                else
                {
                    currentRoot = currentRoot?.children?.FirstOrDefault() ?? currentRoot;
                }
            }

            return root;
        }

        public static IList<int> PreorderTraversal(this Node root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            result.Add(root.val);

            if (root?.children == null)
            {
                return result;
            }

            foreach (var child in root.children)
            {
                result.AddRange(child.PreorderTraversal());
            }

            return result;
        }
    }
}
