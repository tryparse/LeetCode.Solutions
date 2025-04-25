using LeetCode.Solutions.IsSubsequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy
{
    [TestClass()]
    public class IsSubsequenceSolutionTests
    {
        [DataTestMethod()]
        [DataRow("abc", "ahbgdc", true)]
        [DataRow("axc", "ahbgdc", false)]
        [DataRow("ace", "abcde", true)]
        [DataRow("aec", "abcde", false)]
        [DataRow("aaaaaa", "bbaaaa", false)]
        public void IsSubsequenceTest(string s, string t, bool expected)
        {
            var result = new IsSubsequenceSolution().IsSubsequence(s, t);

            Assert.AreEqual(expected, result);
        }
    }
}