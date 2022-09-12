using System.Linq;
using LeetCode.Solutions.Common.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Solutions.MiddleOfTheLinkedList.Tests
{
    [TestClass()]
    public class MiddleOfTheLinkedListSolutionTests
    {
        [TestMethod()]
        public void MiddleNode_Example1()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var expected = new int[] { 3, 4, 5 };

            var result = new MiddleOfTheLinkedListSolution()
                .MiddleNode(nums.ToLinkedList())
                .ToArray();

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MiddleNode_Example2()
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6 };
            var expected = new int[] { 4, 5, 6 };

            var result = new MiddleOfTheLinkedListSolution()
                .MiddleNode(nums.ToLinkedList())
                .ToArray();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}