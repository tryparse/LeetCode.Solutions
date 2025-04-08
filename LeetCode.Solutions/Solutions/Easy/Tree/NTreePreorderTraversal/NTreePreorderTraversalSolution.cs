using System.Collections.Generic;
using LeetCode.Solutions.Common.NTree;

namespace LeetCode.Solutions.Solutions.Easy.Tree.NTreePreorderTraversal
{
    /// <summary>
    /// https://leetcode.com/problems/n-ary-tree-preorder-traversal/
    /// </summary>
    public class NTreePreorderTraversalSolution
    {
        public IList<int> Preorder(Node root)
        {
            return root.PreorderTraversal();
        }
    }
}
