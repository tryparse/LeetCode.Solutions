﻿using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Easy
{
    [TestClass()]
    public class SearchInsertSolutionTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [DataRow(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [DataRow(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [DataRow(new int[] { 1 }, 1, 0)]
        public void SearchInsertTest(int[] nums, int target, int expected)
        {
            var result = new SearchInsertSolution().SearchInsert(nums, target);

            Assert.AreEqual(expected, result);
        }
    }
}