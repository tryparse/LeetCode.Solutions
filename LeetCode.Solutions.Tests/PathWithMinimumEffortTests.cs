using LeetCode.Solutions.PathWithMinimumEfforts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests
{
    [TestClass()]
    public class PathWithMinimumEffortTests
    {
        [TestMethod]
        public void MinimumEffortPathTest()
        {
            var heights = new int[][] { new int[] { 1, 2, 2 }, new int[] { 3, 8, 2 }, new int[] { 5, 3, 5 } };

            var solver = new PathWithMinimumEffort();

            var result = solver.MinimumEffortPath(heights);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinimumEffortPathTest2()
        {
            var heights = new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 8, 4 }, new int[] { 5, 3, 5 } };

            var solver = new PathWithMinimumEffort();

            var result = solver.MinimumEffortPath(heights);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinimumEffortPathTest3()
        {
            var heights = new int[][]
            {
                new int[] { 1, 2, 1, 1, 1 },
                new int[] { 1, 2, 1, 2, 1 },
                new int[] { 1, 2, 1, 2, 1 },
                new int[] { 1, 2, 1, 2, 1 },
                new int[] { 1, 1, 1, 2, 1 }
            };

            var solver = new PathWithMinimumEffort();

            var result = solver.MinimumEffortPath(heights);

            Assert.AreEqual(0, result);
        }
    }
}