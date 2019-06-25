using LeetCode.Solutions.LinkedListComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.Tests
{
    [TestClass]
    public class LinkedListComponentsTests
    {
        [TestMethod]
        public void LinkedListComponentsTest()
        {
            var solver = new LinkedListComponentsProblem();

            var item0 = new ListNode(0);
            var item1 = new ListNode(1);
            var item2 = new ListNode(2);
            var item3 = new ListNode(3);

            item0.next = item1;
            item1.next = item2;
            item2.next = item3;

            int[] G = { 0, 1, 3 };

            var result = solver.NumComponents(item0, G);

            var expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}
