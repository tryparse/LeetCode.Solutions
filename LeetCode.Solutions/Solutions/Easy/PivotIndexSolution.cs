using System;
using System.Linq;

namespace LeetCode.Solutions.Solutions.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/find-pivot-index/
    /// </summary>
    public class PivotIndexSolution
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var sum = nums.Skip(1).Sum();

            if (sum == 0)
            {
                return 0;
            }

            var sums = RunningSum(nums);
            var reverse = RunningSumReverse(nums);

            for (var i = 0; i < nums.Length; i++)
            {
                if (sums[i] == reverse[i])
                {
                    return i;
                }
            }

            return -1;
        }

        private int[] RunningSum(int[] nums)
        {
            // 1,2,3,4

            if (nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            var result = new int[nums.Length];

            result[0] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }

            return result;
        }

        private int[] RunningSumReverse(int[] nums)
        {
            if (nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            var result = new int[nums.Length];

            result[^1] = nums[^1];

            for (var i = nums.Length - 2; i >= 0; i--)
            {
                result[i] = result[i + 1] + nums[i];
            }

            return result;
        }
    }
}
