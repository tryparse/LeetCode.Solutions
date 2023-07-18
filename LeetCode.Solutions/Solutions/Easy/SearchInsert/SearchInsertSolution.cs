using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Solutions.Easy.SearchInsert
{
    /// <summary>
    /// Given a sorted array of distinct integers and a target value, return the index if the target is found.
    /// If not, return the index where it would be if it were inserted in order.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// <see cref="https://leetcode.com/problems/search-insert-position/"/>/>
    /// </summary>
    public class SearchInsertSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return nums[0] >= target ? 0 : 1;
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
                : nums[middleIndex] >= target ? middleIndex : middleIndex + 1;
        }

        private int GetMiddleIndex(int leftIndex, int rightIndex) => (leftIndex + rightIndex) / 2;
    }
}
