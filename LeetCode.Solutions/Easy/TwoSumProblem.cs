namespace LeetCode.Solutions.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var indicies = new int[2];

            for (var i = 0; i < nums.Length; i++)
            {
                var first = nums[i];

                for (var j = i; j < nums.Length; j++)
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
