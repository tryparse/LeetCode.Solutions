using LeetCode.Solutions.Common.BinaryTree;
using LeetCode.Solutions.Solutions.Easy.ConstructStringFromBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy.ConstructStringFromBinaryTree
{
    [TestClass]
    public class ConstructStringFromBinaryTreeSolutionTests
    {
        [TestMethod]
        public void Tree2strTest()
        {
            var values = new int?[] { 1, 2, 3, 4 };
            var expected = "1(2(4))(3)";
            var root = values.ToTreeNode();

            var result = new ConstructStringFromBinaryTreeSolution().Tree2str(root);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tree2str_WithNullableTest()
        {
            var values = new int?[] { 1, 2, 3, null, 4 };
            var expected = "1(2()(4))(3)";

            var root = values.ToTreeNode();

            var result = new ConstructStringFromBinaryTreeSolution().Tree2str(root);

            Assert.AreEqual(expected, result);
        }
    }
}