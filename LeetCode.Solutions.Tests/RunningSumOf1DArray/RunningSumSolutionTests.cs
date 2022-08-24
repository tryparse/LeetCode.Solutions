using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.RunningSumOf1DArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.RunningSumOf1DArray.Tests
{
    [TestClass()]
    public class RunningSumSolutionTests
    {
        [TestMethod()]
        public void RunningSumTest0()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var result = new RunningSumSolution().RunningSum(nums);

            var expected = new int[] { 1, 3, 6, 10 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RunningSumTest1()
        {
            var nums = new int[] { 1, 1, 1, 1, 1 };

            var result = new RunningSumSolution().RunningSum(nums);

            var expected = new int[] { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RunningSumTest2()
        {
            var nums = new int[] { 3, 1, 2, 10, 1 };

            var result = new RunningSumSolution().RunningSum(nums);

            var expected = new int[] { 3, 4, 6, 16, 17 };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}