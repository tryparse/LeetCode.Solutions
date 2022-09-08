using LeetCode.Solutions.Common.BinaryTree;

namespace LeetCode.Solutions.Solutions.ConstructStringFromBinaryTree
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
    public class ConstructStringFromBinaryTreeSolution
    {
        public string Tree2str(TreeNode root)
        {
            return root.ConvertToString();
        }
    }
}
