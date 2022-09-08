namespace LeetCode.Solutions.Common.BinaryTree
{
    public static class TreeNodeExtensions
    {
        public static TreeNode ToTreeNode(this int?[] values)
        {
            if (values.Length == 0)
            {
                return new TreeNode();
            }

            var nodes = new TreeNode[values.Length];

            for (int i = values.Length - 1; i >= 0; i--)
            {
                if (values[i] == null)
                {
                    nodes[i] = null;
                    continue;
                }

                nodes[i] = new TreeNode(values[i].Value);

                var leftBranchIndex = i * 2 + 1;
                var rightBranchIndex = i * 2 + 2;

                if (leftBranchIndex < values.Length)
                {
                    nodes[i].left = nodes[leftBranchIndex];
                }

                if (rightBranchIndex < values.Length)
                {
                    nodes[i].right = nodes[rightBranchIndex];
                }
            }

            return nodes[0];
        }

        public static string ConvertToString(this TreeNode node)
        {
            if (node == null)
            {
                return string.Empty;
            }

            var hasLeft = node.left != null;
            var hasRight = node.right != null;

            var left = hasLeft ? $"({ConvertToString(node.left)})" : hasRight ? "()" : string.Empty;
            var right = hasRight ? $"({ConvertToString(node.right)})" : string.Empty;

            return $"{node.val}{left}{right}";
        }
    }
}
