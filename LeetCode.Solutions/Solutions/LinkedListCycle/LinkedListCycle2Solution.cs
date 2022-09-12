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

            var dictionary = new Dictionary<int, ListNode>();

            var current = head;
            var index = 0;

            dictionary.Add(index, current);

            while (current.next != null)
            {
                if (dictionary.ContainsValue(current.next))
                {
                    return current.next;
                }

                dictionary.Add(++index, current.next);
                current = current.next;
            }

            if (dictionary[index].next == null)
            {
                return null;
            }

            return dictionary[index].next;
        }
    }
}
