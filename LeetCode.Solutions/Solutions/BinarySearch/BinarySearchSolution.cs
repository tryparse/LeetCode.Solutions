using System;

namespace LeetCode.Solutions.Solutions.BinarySearch
{
    /// <summary>
    /// https://leetcode.com/problems/binary-search/
    /// </summary>
    public class BinarySearchSolution
    {
        private int _offset = 0;

        public int Search(int[] nums, int target)
        {
            if (nums == null
                || nums.Length == 0)
            {
                return -1;
            }

            if (nums.Length == 1)
            {
                return nums[0] == target ? _offset : -1;
            }

            var middleIndex = nums.Length / 2;
            var middle = nums[middleIndex];

            if (middle == target)
            {
                return middleIndex + _offset;
            }
            
            if (middle > target)
            {
                return ProcessLeftHalf(nums, target, middleIndex);
            }
            else
            {
                return ProcessRightHalf(nums, target, middleIndex);
            }
        }

        private int ProcessRightHalf(int[] nums, int target, int middleIndex)
        {
            var right = new int[nums.Length - middleIndex - 1];
            Array.Copy(nums, middleIndex + 1, right, 0, nums.Length - middleIndex - 1);

            _offset += middleIndex + 1;

            return Search(right, target);
        }

        private int ProcessLeftHalf(int[] nums, int target, int middleIndex)
        {
            var left = new int[nums.Length - middleIndex - (nums.Length % 2 == 0 ? 0 : 1)];
            Array.Copy(nums, left, middleIndex);

            return Search(left, target);
        }
    }
}
