using System.Linq;
using LeetCode.Solutions.Common.Dijkstra.Generic;
using LeetCode.Solutions.Common.Dijkstra.HeightGrid;

namespace LeetCode.Solutions.Solutions.Medium.PathWithMinimumEfforts
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>https://leetcode.com/problems/path-with-minimum-effort/</remarks>
    public class PathWithMinimumEffort
    {
        public int MinimumEffortPath(int[][] heights)
        {
            var graph = new DijkstraHeightGridGraphBuilder()
                .Build(heights);

            graph.CalculateDistance(null, DijkstraDistanceCalculationType.MinEffort);

            var minEffort = graph.Nodes.LastOrDefault()?.Distance;

            return minEffort ?? 0;
        }
    }
}
