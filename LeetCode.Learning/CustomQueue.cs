namespace LeetCode.Learning
{
    public class CustomQueue<T>
    {
        private T[] _array;
        private int _dequeuePointer;
        private int _enqueuePointer;
        private int _count;

        private readonly int _capacity;
        private readonly bool _fixedCapacity;

        public int Count => _count;

        public CustomQueue(int capacity, bool fixedSize = false)
        {
            _capacity = capacity;
            _array = new T[capacity];
            _fixedCapacity = fixedSize;

            _dequeuePointer = 0;
            _enqueuePointer = 0;
        }

        public bool Enqueue(T item)
        {
            /*  0
             * [1][2][3][4][5]
             *              4
             * count=5
             * capacity=5
             */

            if (_fixedCapacity)
            {
                if (_count == _capacity)
                {
                    return false;
                }

                _array[_enqueuePointer] = item;
                _enqueuePointer++;
                _count++;

                if (_enqueuePointer == _capacity)
                {
                    _enqueuePointer = 0;
                }

                return true;
            }

            if (_count == _capacity)
            {
                ExtendArray();
            }

            EnqueueInternal(item);

            return true;
        }

        private void EnqueueInternal(T item)
        {
            _array[_enqueuePointer] = item;
            _enqueuePointer++;
            _count++;
        }

        public bool Dequeue(out T? result)
        {
            if (_count <= 0)
            {
                result = default;
                return false;
            }

            result = _array[_dequeuePointer];
            _dequeuePointer++;
            _count--;

            if (_dequeuePointer == _capacity)
            {
                _dequeuePointer = 0;
            }

            return true;
        }

        private void ExtendArray()
        {
            var extendedCapacity = _capacity + _capacity / 2;
            var extendedArray = new T[extendedCapacity];
            Array.Copy(_array, extendedArray, _array.Length);
            _array = extendedArray;
        }
    }
}
