using System.Collections.Generic;
using LeetCode.Solutions.Common.LinkedList;

namespace LeetCode.Solutions.Solutions.Medium.LinkedListCycle
{
    public class LinkedListCycle2Solution
    {
        public ListNode<int> DetectCycle(ListNode<int> head)
        {
            if (head == null)
            {
                return null;
            }

            var set = new HashSet<ListNode<int>>
            {
                head
            };

            while (head.Next != null)
            {
                if (set.Contains(head.Next))
                {
                    return head.Next;
                }

                set.Add(head.Next);
                head = head.Next;
            }

            return null;
        }
    }
}
