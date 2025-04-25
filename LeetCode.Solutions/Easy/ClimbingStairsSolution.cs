using System.Collections.Generic;

namespace LeetCode.Solutions.Easy
{
    public class ClimbingStairsSolution
    {
        private Dictionary<int, int> _cache = [];

        public int ClimbStairs(int n)
        {
            if (_cache.ContainsKey(n))
            {
                return _cache[n];
            }

            if (n == 1) return 1;

            if (n == 2) return 2;

            var result = ClimbStairs(n - 2) + ClimbStairs(n - 1);

            if (!_cache.ContainsKey(n))
            {
                _cache.Add(n, result);
            }

            return result;
        }

        // 1 1 1 1
        // 1 1 2
        // 1 2 1
        // 2 1 1
        // 2 2

        // 1 1 1 1 1
        // 1 1 1 2
        // 1 1 2 1
        // 1 2 1 1
        // 2 1 1 1
        // 2 2 1
        // 2 1 2
    }
}
