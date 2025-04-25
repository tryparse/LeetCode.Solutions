using LeetCode.Solutions.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Medium
{
    [TestClass()]
    public class AsteroidCollisionSolutionTests
    {
        [TestMethod()]
        [DataRow(new int[] { 5, 10, -5 }, new int[] { 5, 10 })]
        [DataRow(new int[] { 8, -8 }, new int[0])]
        [DataRow(new int[] { 10, 2, -5 }, new int[] { 10 })]
        [DataRow(new int[] { -1, -2, -3, 10 }, new int[] { -1, -2, -3, 10 })]
        [DataRow(new int[] { -2, -1, 1, 2 }, new int[] { -2, -1, 1, 2 })]
        public void AsteroidCollisionTest(int[] asteroids, int[] expected)
        {
            var result = new AsteroidCollisionSolution().AsteroidCollision(asteroids);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}