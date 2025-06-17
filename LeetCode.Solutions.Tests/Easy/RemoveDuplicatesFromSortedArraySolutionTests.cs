using LeetCode.Solutions.Easy;
using Shouldly;
using Xunit;

namespace LeetCode.Solutions.Tests.Easy
{
    public class RemoveDuplicatesFromSortedArraySolutionTests
    {
        [Theory]
        [InlineData(new[] { 1, 1, 2 }, 2)]
        [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void RemoveDuplicatesTest(int[] nums, int expected)
        {
            var result = new RemoveDuplicatesFromSortedArraySolution().RemoveDuplicates(nums);
            result.ShouldBe(expected);
        }
    }
}