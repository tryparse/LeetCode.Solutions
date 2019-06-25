using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LinkedListComponents
{
    /// <summary>
    ///  Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    /// <summary>
    /// https://leetcode.com/contest/weekly-contest-80/problems/linked-list-components/
    /// </summary>
    public class LinkedListComponentsProblem
    {
        public int NumComponents(ListNode head, int[] G)
        {
            var current = head;

            while (current.next != null)
            {
                foreach (var g in G)
                {

                }

                current = current.next;
            }

            return 0;
        }
    }
}
