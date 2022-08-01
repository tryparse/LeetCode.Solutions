using LeetCode.Solutions.ReverseInteger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests
{
    [TestClass]
    public class ReverseIntegerTests
    {
        [DataTestMethod]
        [DataRow(123, 321)]
        [DataRow(-123, -321)]
        [DataRow(120, 21)]
        [DataRow(0, 0)]
        [DataRow(1534236469, 0)]
        public void SolutionTest(int x, int expected)
        {
            var solution = new ReverseIntegerProblem();

            var result = solution.Reverse(x);

            Assert.AreEqual(expected, result);
        }
    }
}
