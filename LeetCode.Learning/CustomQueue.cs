namespace LeetCode.Learning
{
    public class CustomQueue<T>
    {
        private readonly T[] _array;
        private readonly int _headPointer;
        private readonly int _tailPointer;
        private readonly int _capacity;
        private readonly bool _fixedSize;

        public int Count => _array.Length;

        public CustomQueue(int capacity, bool fixedSize = false)
        {
            _capacity = capacity;
            _array = new T[capacity];
            _fixedSize = fixedSize;
            
            _headPointer = 0;
            _tailPointer = 0;
        }

        public bool Enqueue(T item)
        {
            if (_fixedSize)
            {
                if 
            }
        }

        public T Dequeue()
        {
        }
    }
}
