using LeetCode.Solutions.Solutions.Easy.FibonachiNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy.FibonachiNumber
{
    [TestClass()]
    public class FibonachiNumberSolutionTests
    {
        [DataTestMethod()]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        public void FibTest(int n, int expected)
        {
            var result = new FibonachiNumberSolution().Fib(n);

            Assert.AreEqual(expected, result);
        }
    }
}