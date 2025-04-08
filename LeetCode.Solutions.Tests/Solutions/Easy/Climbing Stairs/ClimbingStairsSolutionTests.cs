using Shouldly;
using Xunit;

namespace LeetCode.Solutions.Solutions.Easy.Climbing_Stairs.Tests
{
    public class ClimbingStairsSolutionTests
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void ClimbStairsTest(int n, int expected)
        {
            var act = () => new ClimbingStairsSolution().ClimbStairs(n);

            act.ShouldNotThrow();
            act().ShouldBe(expected);
        }
    }
}