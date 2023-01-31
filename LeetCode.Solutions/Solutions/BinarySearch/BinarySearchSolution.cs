using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Solutions.BinarySearch
{
    public class BinarySearchSolution
    {
        public int Search(int[] nums, int target, int offset = 0)
        {
            if (nums == null
                || nums.Length == 0)
            {
                return -1;
            }

            if (nums.Length == 1)
            {
                return nums[0] == target ? 0 + offset : -1;
            }

            var middleIndex = nums.Length / 2;
            var middle = nums[middleIndex];

            if (middle == target)
            {
                return middleIndex + offset;
            }
            
            if (middle > target)
            {
                var left = new int[nums.Length - middleIndex];
                Array.Copy(nums, left, middleIndex);
                return Search(left, target) + offset;
            }
            else
            {
                var right = new int[nums.Length - middleIndex - 1];
                Array.Copy(nums, middleIndex + 1, right, 0, nums.Length - middleIndex - 1);
                return Search(right, target, middleIndex);
            }
        }
    }
}
