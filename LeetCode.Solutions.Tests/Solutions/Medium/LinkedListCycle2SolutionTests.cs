using LeetCode.Solutions.Common.LinkedList;
using LeetCode.Solutions.Solutions.Medium.LinkedListCycle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Medium
{
    [TestClass()]
    public class LinkedListCycle2SolutionTests
    {
        [TestMethod()]
        public void DetectCycle_Example1()
        {
            var nums = new int[] { 3, 2, 0, -4 };
            var pos = 1;
            var nodes = nums.ToLinkedListWithCycle(pos);

            var result = new LinkedListCycle2Solution().DetectCycle(nodes[0]);

            Assert.AreEqual(result, nodes[pos]);
        }

        [TestMethod()]
        public void DetectCycle_Example2()
        {
            var nums = new int[] { 1, 2 };
            var pos = 0;
            var nodes = nums.ToLinkedListWithCycle(pos);

            var result = new LinkedListCycle2Solution().DetectCycle(nodes[0]);

            Assert.AreEqual(result, nodes[pos]);
        }

        [TestMethod()]
        public void DetectCycle_Example3()
        {
            var nums = new int[] { 1 };
            var pos = -1;
            var nodes = nums.ToLinkedListWithCycle(pos);

            var result = new LinkedListCycle2Solution().DetectCycle(nodes[0]);

            Assert.AreEqual(result, null);
        }
    }
}