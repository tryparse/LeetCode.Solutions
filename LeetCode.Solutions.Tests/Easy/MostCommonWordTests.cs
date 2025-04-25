using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Easy
{
    [TestClass]
    public class MostCommonWordTests
    {
        [DataTestMethod]
        //[DataRow("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" }, "ball")]
        [DataRow("a, a, a, a, b,b,b,c, c", new string[] { "a" }, "b")]
        public void MostCommonWordTest(string paragraph, string[] banned, string expected)
        {
            var solver = new MostCommonWordProblem();

            var result = solver.MostCommonWord(paragraph, banned);

            Assert.AreEqual(expected, result);
        }
    }
}