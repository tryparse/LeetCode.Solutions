using LeetCode.Solutions.RomanToInteger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy
{
    [TestClass]
    public class RomanToIntegerTests
    {
        [DataTestMethod]
        [DataRow("I", 1)]
        [DataRow("V", 5)]
        [DataRow("X", 10)]
        [DataRow("L", 50)]
        [DataRow("C", 100)]
        [DataRow("D", 500)]
        [DataRow("M", 1000)]
        public void DigitsConvertingTest(string input, int expected)
        {
            var solver = new RomanToIntegerProblem();

            var result = solver.RomanToInt(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("IX", 9)]
        [DataRow("LVIII", 58)]
        [DataRow("MCMXCIV", 1994)]
        public void NumbersConvertingTest(string input, int expected)
        {
            var solver = new RomanToIntegerProblem();

            var result = solver.RomanToInt(input);

            Assert.AreEqual(expected, result);
        }
    }
}
