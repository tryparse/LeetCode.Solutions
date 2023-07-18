using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Solutions.Common.LinkedList;

namespace LeetCode.Solutions.Solutions.ReverseLinkedList
{
    public class ReverseLinkedListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            var stack = new Stack<ListNode>();

            var node = head;
            stack.Push(node);

            while(node.next != null)
            {
                stack.Push(node.next);
                node = node.next;
            }

            var reverseHead = stack.Pop();

            if (stack.Count > 0)
            {
                reverseHead.next = stack.Pop();

                node = reverseHead.next;

                while (stack.Count > 0)
                {
                    node.next = stack.Pop();
                    node = node.next;
                }

                node.next = null;
            }

            return reverseHead;
        }
    }
}
