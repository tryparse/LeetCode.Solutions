using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Solutions.Common.NTree;

namespace LeetCode.Solutions.Solutions.NaryTreePreorderTraversal
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
