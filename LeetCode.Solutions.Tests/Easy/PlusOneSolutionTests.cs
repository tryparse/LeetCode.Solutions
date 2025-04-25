using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Easy
{
    [TestClass()]
    public class PlusOneSolutionTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [DataRow(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [DataRow(new int[] { 9 }, new int[] { 1, 0 })]
        [DataRow(new int[] { 9, 9 }, new int[] { 1, 0, 0 })]
        [DataRow(new int[] { 8, 9, 9, 9 }, new int[] { 9, 0, 0, 0 })]
        public void PlusOneTest(int[] digits, int[] expected)
        {
            var result = new PlusOneSolution().PlusOne(digits);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
