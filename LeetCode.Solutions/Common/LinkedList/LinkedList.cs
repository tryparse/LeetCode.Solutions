namespace LeetCode.Solutions.Common.LinkedList
{
    public class LinkedList<T>(ListNode<T> head)
    {
        public void Add(T value)
        {
            var addedHead = AddHeadIfNull(ref head, value);

            if (!addedHead)
            {
                var tail = GetLastItem(head);

                tail.Next = new ListNode<T>(value);
            }
        }

        private static ListNode<T> GetLastItem(ListNode<T> head)
        {
            var current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        private static bool AddHeadIfNull(ref ListNode<T> head, T value)
        {
            if (head == null)
            {
                head = new ListNode<T>(value);
                return true;
            }

            return false;
        }
    }
}
