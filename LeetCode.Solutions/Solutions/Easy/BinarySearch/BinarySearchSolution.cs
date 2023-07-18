using System;

namespace LeetCode.Solutions.Solutions.Easy.BinarySearch
{
    /// <summary>
    /// https://leetcode.com/problems/binary-search/
    /// </summary>
    public class BinarySearchSolution
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null
                || nums.Length == 0)
            {
                return -1;
            }

            if (nums.Length == 1)
            {
                return nums[0] == target
                    ? 0
                    : -1;
            }

            var leftIndex = 0;
            var rightIndex = nums.Length - 1;
            var middleIndex = GetMiddleIndex(leftIndex, rightIndex);

            while (leftIndex < rightIndex)
            {
                if (nums[middleIndex] == target)
                {
                    return middleIndex;
                }

                if (nums[middleIndex] > target)
                {
                    rightIndex = middleIndex;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }

                middleIndex = GetMiddleIndex(leftIndex, rightIndex);
            }

            return nums[middleIndex] == target
                ? middleIndex
                : -1;
        }

        private int GetMiddleIndex(int leftIndex, int rightIndex) => (leftIndex + rightIndex) / 2;
    }
}
