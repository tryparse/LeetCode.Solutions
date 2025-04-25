using LeetCode.Solutions.Easy;
using Shouldly;
using Xunit;

namespace LeetCode.Solutions.Tests.Easy
{
    public class ExcelSheetColumnTitleTests
    {
        [Theory]
        [InlineData(1, "A")]
        [InlineData(2, "B")]
        [InlineData(3, "C")]
        [InlineData(26, "Z")]
        [InlineData(27, "AA")]
        [InlineData(28, "AB")]
        [InlineData(701, "ZY")]
        [InlineData(52, "AZ")]
        public void ConvertToTitleTest(int n, string expected)
        {
            var act = () => new ExcelSheetColumnTitleSolution().ConvertToTitle(n);

            act.ShouldNotThrow();
            act().ShouldBe(expected);
        }
    }
}