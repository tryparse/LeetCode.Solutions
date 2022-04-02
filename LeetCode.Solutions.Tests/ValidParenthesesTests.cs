using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests
{
    [TestClass]
    public class ValidParenthesesTests
    {
        [DataTestMethod]
        [DataRow("()", true)]
        [DataRow("()[]{}", true)]
        [DataRow("(]", false)]
        [DataRow("([)]", false)]
        [DataRow("{[]}", true)]
        public void ValidParenthesesTest(string s, bool expected)
        {
            var solver = new ValidParenthesesProblem();

            var actual = solver.IsValid(s);

            Assert.AreEqual(expected, actual);
        }
    }
}
