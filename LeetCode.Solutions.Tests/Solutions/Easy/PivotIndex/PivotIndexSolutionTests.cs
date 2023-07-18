using LeetCode.Solutions.PivotIndex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy.PivotIndex
{
    [TestClass()]
    public class PivotIndexSolutionTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
        [DataRow(new int[] { 1, 2, 3 }, -1)]
        [DataRow(new int[] { 2, 1, -1 }, 0)]
        public void PivotIndexTest(int[] nums, int expected)
        {
            var result = new PivotIndexSolution().PivotIndex(nums);

            Assert.AreEqual(expected, result);
        }
    }
}