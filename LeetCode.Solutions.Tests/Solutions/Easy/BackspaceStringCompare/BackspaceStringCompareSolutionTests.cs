using LeetCode.Solutions.Solutions.Easy.BackspaceStringCompare;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy.BackspaceStringCompare
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