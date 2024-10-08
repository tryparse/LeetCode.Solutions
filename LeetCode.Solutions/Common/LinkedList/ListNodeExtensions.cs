using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Common.LinkedList
{
    public static class ListNodeExtensions
    {
        public static T[] ToArray<T>(this ListNode<T> listNode)
        {
            if (listNode == null)
            {
                return [];
            }

            var result = new List<T>();

            do
            {
                result.Add(listNode.Value);
                listNode = listNode.Next;
            }
            while (listNode != null);

            return [.. result];
        }

        public static ListNode<T>[] ToArrayOfNodes<T>(this ListNode<T> listNode)
        {
            var result = new List<ListNode<T>>();

            return [.. result];
        }

        public static ListNode<T> ToLinkedList<T>(this T[] array)
        {
            if (array == null)
            {
                return null;
            }

            if (array.Length == 0)
            {
                return null;
            }

            ListNode<T> result = new ListNode<T>(array[0]);
            ListNode<T> next = result;

            foreach (var item in array.Skip(1))
            {
                next.Next = new ListNode<T>(item);
                next = next.Next;
            }

            return result;
        }

        public static ListNode<T>[] ToLinkedListWithCycle<T>(this T[] items, int cyclePosition)
        {
            if (items == null)
            {
                return null;
            }

            if (items.Length == 0)
            {
                return null;
            }

            var array = new ListNode<T>[items.Length];

            ListNode<T> head = new(items[0]);
            ListNode<T> next = head;
            array[0] = next;

            var index = 0;

            foreach (var item in items.Skip(1))
            {
                next.Next = new ListNode<T>(item);
                next = next.Next;
                array[++index] = next;
            }

            if (cyclePosition >= 0)
            {
                array[^1].Next = array[cyclePosition];
            }

            return array;
        }
    }
}
