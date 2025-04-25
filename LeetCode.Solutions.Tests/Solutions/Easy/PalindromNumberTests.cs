using LeetCode.Solutions.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy
{
    [TestClass]
    public class PalindromNumberTests
    {
        private readonly PalindromeNumberProblem solver = new PalindromeNumberProblem();

        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        [DataRow(1, true)]
        [DataRow(11, true)]
        [DataRow(111, true)]
        [DataRow(1121, false)]
        public void SolutionTest(int x, bool expected)
        {
            var result = solver.IsPalindrome(x);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        [DataRow(1, true)]
        [DataRow(11, true)]
        [DataRow(111, true)]
        [DataRow(1121, false)]
        public void SolutionTest2(int x, bool expected)
        {
            var result = solver.IsPalindrome2(x);

            Assert.AreEqual(expected, result);
        }
    }
}
