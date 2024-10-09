using System.Linq;
using LeetCode.Solutions.Common.LinkedList;
using LeetCode.Solutions.Solutions.Easy.ReverseLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy.ReverseLinkedList
{
    [TestClass()]
    public class ReverseLinkedListSolutionTests
    {
        [TestMethod]
        public void ReverseListTest1()
        {
            var linkedList = new int[] { 1, 2, 3, 4, 5 }.ToLinkedList();
            var result = new ReverseLinkedListSolution()
                .ReverseList(linkedList)
                .ToArray();

            CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, result);
        }

        [TestMethod]
        public void ReverseListTest2()
        {
            var linkedList = new int[] { 1, 2 }.ToLinkedList();
            var result = new ReverseLinkedListSolution()
                .ReverseList(linkedList)
                .ToArray();

            CollectionAssert.AreEqual(new int[] { 2, 1 }, result);
        }

        [TestMethod]
        public void ReverseListTest3()
        {
            var linkedList = new int[0].ToLinkedList();
            var result = new ReverseLinkedListSolution()
                .ReverseList(linkedList)
                .ToArray();

            CollectionAssert.AreEqual(null, result);
        }
    }
}