using System;
using System.Linq;
using LeetCode.Solutions.Common.LinkedList;

namespace LeetCode.Solutions.Solutions.MiddleOfTheLinkedList
{
    public class MiddleOfTheLinkedListSolution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var array = head.ToArray();

            var middleIndex = array.Length / 2;
            var result = new int[array.Length - middleIndex];
            Array.ConstrainedCopy(array, array.Length / 2, result, 0, result.Length);

            return result.ToLinkedList();
        }
    }
}
