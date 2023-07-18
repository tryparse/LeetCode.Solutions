using LeetCode.Solutions.Common.LinkedList;
using LeetCode.Solutions.MergeTwoSortedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy.MergeTwoSortedList
{
    [TestClass()]
    public class MergeTwoSortedListSolutionTests
    {
        [TestMethod]
        public void MergeTwoListsTest()
        {
            var solver = new MergeTwoSortedListSolution();

            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var result = solver.MergeTwoLists(list1, list2)
                .ToArray();

            var expected = new int[] { 1, 1, 2, 3, 4, 4 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_EmptyLists()
        {
            var solver = new MergeTwoSortedListSolution();

            ListNode list1 = null;
            ListNode list2 = null;

            var result = solver.MergeTwoLists(list1, list2).ToArray();

            int[] expected = null;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_OneListIsEmpty()
        {
            var solver = new MergeTwoSortedListSolution();

            ListNode list1 = null;
            ListNode list2 = new ListNode();

            var result = solver.MergeTwoLists(list1, list2).ToArray();

            var expected = new ListNode().ToArray();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}