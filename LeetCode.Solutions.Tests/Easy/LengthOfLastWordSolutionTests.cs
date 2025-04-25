using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Easy
{
    [TestClass()]
    public class LengthOfLastWordSolutionTests
    {
        [DataTestMethod()]
        [DataRow("Hello World", 5)]
        [DataRow("   fly me   to   the moon  ", 4)]
        [DataRow("luffy is still joyboy", 6)]
        public void LengthOfLastWordTest(string s, int expected)
        {
            var result = new LengthOfLastWordSolution().LengthOfLastWord(s);

            Assert.AreEqual(expected, result);
        }
    }
}