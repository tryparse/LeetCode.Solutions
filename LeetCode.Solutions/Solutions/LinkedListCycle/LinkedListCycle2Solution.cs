using LeetCode.Solutions.Common.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Solutions.LinkedListCycle
{
    public class LinkedListCycle2Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var set = new HashSet<ListNode>
            {
                head
            };

            while (head.next != null)
            {
                if (set.Contains(head.next))
                {
                    return head.next;
                }

                set.Add(head.next);
                head = head.next;
            }

            return null;
        }
    }
}
