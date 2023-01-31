using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Solutions.BinarySearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Solutions.BinarySearch.Tests
{
    [TestClass()]
    public class BinarySearchSolutionTests
    {
        [DataTestMethod()]
        [DataRow(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4 )]
        [DataRow(new int[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
        [DataRow(new int[] { 2, 5 }, 2, 0)]
        public void SearchTest(int [] nums, int target, int expectedIndex)
        {
            var actual = new BinarySearchSolution().Search(nums, target);

            Assert.AreEqual(expectedIndex, actual);
        }
    }
}