﻿using System.Linq;
using LeetCode.Solutions.Common.LinkedList;

namespace LeetCode.Solutions.Easy
{
    public class MergeTwoSortedListSolution
    {
        public ListNode<int> MergeTwoLists(ListNode<int> list1, ListNode<int> list2)
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
                .ToLinkedList();
        }
    }
}
