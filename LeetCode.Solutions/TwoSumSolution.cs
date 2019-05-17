using System;

namespace LeetCode.Solutions
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var indicies = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int first = nums[i];

                for (int j = i; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    var second = nums[j];

                    if (first + second == target)
                    {
                        indicies[0] = i;
                        indicies[1] = j;

                        return indicies;
                    }
                }
            }

            return indicies;
        }
    }
}
