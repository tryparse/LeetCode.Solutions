using System.Collections.Generic;

namespace LeetCode.Solutions.Solutions.Easy.NumberOfRecentCalls
{
    public class RecentCounter
    {
        private readonly Queue<int> _pings = new();
        private int _previousTime = 0;
        private int _left = -3000;

        public RecentCounter()
        {
        }

        public int Ping(int t)
        {
            var dt = t - _previousTime;

            _left += dt;

            while (_pings.TryPeek(out var first) && first < _left)
            {
                _pings.Dequeue();
            }

            _pings.Enqueue(t);

            _previousTime = t;

            return _pings.Count;
        }
    }

    /**
     * Your RecentCounter object will be instantiated and called as such:
     * RecentCounter obj = new RecentCounter();
     * int param_1 = obj.Ping(t);
     */
}
