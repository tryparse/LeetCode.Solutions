using LeetCode.Solutions.TwoSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests
{
    [TestClass]
    public class TwoSumTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void CorrectnessTest(int [] nums, int target, int [] expected)
        {
            var solution = new TwoSumProblem();

            var result = solution.TwoSum(nums, target);

            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
