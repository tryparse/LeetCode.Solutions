using System.Linq;
using LeetCode.Solutions.Common.NTree;
using LeetCode.Solutions.Solutions.Easy.Tree.NTreePreorderTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy.Tree.NTreePreorderTraversal
{
    [TestClass()]
    public class NTreePreorderTraversalSolutionTests
    {
        [TestMethod()]
        public void Preorder_Example1()
        {
            var input = new int?[] { 1, null, 3, 2, 4, null, 5, 6 };
            var expected = new int[] { 1, 3, 5, 6, 2, 4 };

            var actual = new NTreePreorderTraversalSolution().Preorder(input.ToTree());

            CollectionAssert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestMethod()]
        public void Preorder_Example2()
        {
            var input = new int?[] { 1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14 };
            var expected = new int[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 };

            var actual = new NTreePreorderTraversalSolution().Preorder(input.ToTree());

            CollectionAssert.AreEqual(expected.ToArray(), actual.ToArray());
        }
    }
}