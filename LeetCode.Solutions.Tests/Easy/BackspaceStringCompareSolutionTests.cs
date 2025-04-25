using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Easy
{
    [TestClass()]
    public class BackspaceStringCompareSolutionTests
    {
        [DataTestMethod()]
        [DataRow("ab#c", "ad#c", true)]
        [DataRow("ab##", "c#d#", true)]
        [DataRow("a#c", "b", false)]
        public void BackspaceCompareTest(string s, string t, bool expected)
        {
            var result = new BackspaceStringCompareSolution().BackspaceCompare(s, t);

            Assert.AreEqual(expected, result);
        }
    }
}