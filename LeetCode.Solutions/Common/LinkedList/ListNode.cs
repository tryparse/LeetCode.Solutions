namespace LeetCode.Solutions.Common.LinkedList
{
    public class ListNode<T>(T value = default, ListNode<T> next = null)
    {
        public T Value { get; set; } = value;
        public ListNode<T> Next { get; set; } = next;
    }
}
