using LeetCode.Solutions.Solutions.Easy.StrStr;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy
{
    [TestClass()]
    public class StrStrSolutionTests
    {
        [DataTestMethod()]
        [DataRow("hello", "ll", 2)]
        [DataRow("aaaaa", "bba", -1)]
        [DataRow("mississippi", "issipi", -1)]
        public void StrStrTest1(string haystack, string needle, int expected)
        {
            var actual = new StrStrSolution().StrStr(haystack, needle);

            Assert.AreEqual(expected, actual);
        }
    }
}