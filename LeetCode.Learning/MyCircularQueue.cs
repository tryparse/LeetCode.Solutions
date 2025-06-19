namespace LeetCode.Learning
{
    public class MyCircularQueue
    {
        private const int _defaultValue = -1;

        private readonly int[] _array;

        private int _enqueueIndex = 0;
        private int _dequeueIndex = 0;
        private int _count = 0;

        public MyCircularQueue(int k)
        {
            _array = new int[k];
            Array.Fill(_array, -1);
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            if (!IsEmpty())
            {
                IncrementEnqueueIndex();
            }

            _array[_enqueueIndex] = value;

            _count++;

            return true;
        }

        private void IncrementEnqueueIndex()
        {
            _enqueueIndex++;

            if (_enqueueIndex == _array.Length)
            {
                _enqueueIndex = 0;
            }
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }

            _array[_dequeueIndex] = _defaultValue;
            _count--;

            if (!IsEmpty())
            {
                IncrementDequeueIndex();
            }

            return true;
        }

        private void IncrementDequeueIndex()
        {
            _dequeueIndex++;

            if (_dequeueIndex == _array.Length)
            {
                _dequeueIndex = 0;
            }
        }

        public int Front()
        {
            if (IsEmpty())
            {
                return _defaultValue;
            }

            return _array[_dequeueIndex];
        }

        public int Rear()
        {
            if (IsEmpty())
            {
                return _defaultValue;
            }

            return _array[_enqueueIndex];
        }

        public bool IsEmpty() => _count == 0;

        public bool IsFull() => _count == _array.Length;
    }

    public class LinkedListQueue<T>
    {
        private class Node
        {
            public required T Value;
            public Node? Next;
        }

        private Node? _head;
        private Node? _tail;

        public void Enqueue(T value)
        {
            if (_head is null)
            {
                _head = new Node { Value = value };
                _tail = _head;
            }
            else
            {
                _tail.Next = new Node { Value = value };
                _tail = _tail.Next;
            }
        }

        public T Dequeue()
        {
            if (_tail is null)
            {
                return default;
            }

            var value = _tail.Value;
        }
    }
}
