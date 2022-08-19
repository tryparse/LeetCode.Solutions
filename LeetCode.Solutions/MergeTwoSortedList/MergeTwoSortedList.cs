using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.MergeTwoSortedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

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

        public static ListNode ToListNode(this int[] array)
        {
            if (array == null)
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

    public class MergeTwoSortedListSolution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            var list1Values = list1.ToArray();
            var list2Values = list2.ToArray();

            var union = list1Values
                .ToList();

            union
                .AddRange(list2Values);

            return union
                .OrderBy(x => x)
                .ToArray()
                .ToListNode();
        }
    }
}
