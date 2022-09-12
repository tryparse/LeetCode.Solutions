using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Common.LinkedList
{
    public static class ListNodeExtensions
    {
        public static int[] ToArray(this ListNode listNode)
        {
            if (listNode == null)
            {
                return null;
            }

            var result = new List<int>();

            do
            {
                result.Add(listNode.val);
                listNode = listNode.next;
            }
            while (listNode != null);

            return result.ToArray();
        }

        public static ListNode[] ToArrayOfNodes(this ListNode listNode)
        {
            var result = new List<ListNode>();

            return result.ToArray();
        }

        public static ListNode ToLinkedList(this int[] array)
        {
            if (array == null)
            {
                return null;
            }

            if (array.Length == 0)
            {
                return null;
            }

            ListNode result = new ListNode(array[0]);
            ListNode next = result;

            foreach (var item in array.Skip(1))
            {
                next.next = new ListNode(item);
                next = next.next;
            }

            return result;
        }

        public static ListNode[] ToLinkedListWithCycle(this int[] nums, int cyclePosition)
        {
            if (nums == null)
            {
                return null;
            }

            if (nums.Length == 0)
            {
                return null;
            }

            var array = new ListNode[nums.Length];

            ListNode head = new(nums[0]);
            ListNode next = head;
            array[0] = next;

            var index = 0;

            foreach (var item in nums.Skip(1))
            {
                next.next = new ListNode(item);
                next = next.next;
                array[++index] = next;
            }

            if (cyclePosition >= 0)
            {
                array[^1].next = array[cyclePosition];
            }

            return array;
        }
    }
}
