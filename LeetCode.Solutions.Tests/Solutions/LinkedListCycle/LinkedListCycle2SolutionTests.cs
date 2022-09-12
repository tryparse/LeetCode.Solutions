using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Solutions.LinkedListCycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Solutions.Common.LinkedList;

namespace LeetCode.Solutions.Solutions.LinkedListCycle.Tests
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