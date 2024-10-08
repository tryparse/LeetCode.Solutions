using System.Collections.Generic;
using LeetCode.Solutions.Common.LinkedList;

namespace LeetCode.Solutions.Solutions.Easy.ReverseLinkedList
{
    public class ReverseLinkedListSolution
    {
        public ListNode<int> ReverseList(ListNode<int> head)
        {
            if (head?.Next == null)
            {
                return head;
            }

            var stack = new Stack<ListNode<int>>();

            var node = head;
            stack.Push(node);

            while (node.Next != null)
            {
                stack.Push(node.Next);
                node = node.Next;
            }

            var reverseHead = stack.Pop();

            if (stack.Count > 0)
            {
                reverseHead.Next = stack.Pop();

                node = reverseHead.Next;

                while (stack.Count > 0)
                {
                    node.Next = stack.Pop();
                    node = node.Next;
                }

                node.Next = null;
            }

            return reverseHead;
        }
    }
}
