namespace LeetCode.Learning.NTree
{
    public class Node<T>
    {
        public T Value;
        public List<Node<T>>? Children;

        public Node(T _value)
        {
            Value = _value;
        }

        public Node(T value, List<Node<T>> _children)
        {
            Value = value;
            Children = _children;
        }

        public override string? ToString() => Value?.ToString();
    }
}
