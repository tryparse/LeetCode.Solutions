using LeetCode.Solutions.Common.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Solutions.Tree.BinaryTree.BinaryTreeLevelOrderTraversal
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    public class BinaryTreeLevelOrderTraversalSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var levels = new List<List<int>>();

            if (root == null)
            {
                return levels.ToArray();
            }
            
            if (root.left == null
                && root.right == null)
            {
                levels.Add(new List<int> { root.val });
                return levels.ToArray();
            }

            return levels.ToArray();
        }
    }
}
