using LeetCode.Solutions.Solutions.Easy;
using Shouldly;
using Xunit;

namespace LeetCode.Solutions.Tests.Solutions.Easy
{
    public class HappyNumberSolutionTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void IsHappyTest(int n, bool expected)
        {
            var result = new HappyNumberSolution().IsHappy(n);

            result.ShouldBe(expected);
        }

        public static TheoryData<int, bool> TestData =>
            new TheoryData<int, bool>
            {
                { 19, true },
                { 2, false }
            };
    }
}