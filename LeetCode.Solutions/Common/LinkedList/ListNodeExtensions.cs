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
    }
}
