using System;
using System.Collections.Generic;
using LeetCode.Solutions.Common.LinkedList;

namespace LeetCode.Solutions.Solutions.Easy.MiddleOfTheLinkedList
{
    public class MiddleOfTheLinkedListSolution
    {
        public ListNode MiddleNode(ListNode head)
        {
            //var array = head.ToArray();

            //var middleIndex = array.Length / 2;
            //var result = new int[array.Length - middleIndex];
            //Array.ConstrainedCopy(array, array.Length / 2, result, 0, result.Length);

            //return result.ToLinkedList();

            var stack = new Stack<ListNode>();

            var current = head;
            var count = 1;

            stack.Push(current);

            while (current.next != null)
            {
                stack.Push(current.next);
                count++;
                current = current.next;
            }

            var middleIndex = count % 2 == 0 ? count / 2 - 1 : count / 2;

            for (var i = 0; i < middleIndex; i++)
            {
                stack.Pop();
            }

            return stack.Pop();
        }
    }
}
