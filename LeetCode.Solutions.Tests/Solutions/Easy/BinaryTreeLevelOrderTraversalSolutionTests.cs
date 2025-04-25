using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Solutions.Common.BinaryTree;
using LeetCode.Solutions.Solutions.Tree.BinaryTree.BinaryTreeLevelOrderTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy
{
    [TestClass()]
    public class BinaryTreeLevelOrderTraversalSolutionTests
    {
        [TestMethod()]
        public void LevelOrder_Example1()
        {
            var input = new int?[] { 3, 9, 20, null, null, 15, 7 };

            var result = new BinaryTreeLevelOrderTraversalSolution()
                .LevelOrder(input.ToTreeNode());

            var expected = new int[][]
            {
                new [] { 3 },
                new [] { 9, 20 },
                new [] { 15, 7 }
            }.ToArray();

            CollectionAssert.AreEqual(expected, result.ToArray());
        }

        [TestMethod()]
        public void GivenTreeWithOneItem_WhenLevelOrderCalled_ThenReturnOneLevelList()
        {
            var input = new int?[] { 1 };

            var result = new BinaryTreeLevelOrderTraversalSolution()
                .LevelOrder(input.ToTreeNode());

            var expected = new List<List<int>>
            {
                new List<int> { 1 }
            }.ToArray();

            CollectionAssert.AreEqual(expected, result.ToArray());
        }

        [TestMethod()]
        public void GivenTreeWithoutItems_WhenLevelOrderCalled_ThenReturnEmptyList()
        {
            var input = Array.Empty<int?>();

            var result = new BinaryTreeLevelOrderTraversalSolution()
                .LevelOrder(input.ToTreeNode());

            var expected = new List<List<int>>();

            CollectionAssert.AreEqual(expected, result.ToArray());
        }
    }
}