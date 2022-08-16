using System.Linq;
using LeetCode.Solutions.Common.Dijkstra.Generic;

namespace LeetCode.Solutions.Common.Dijkstra
{
    public static class NodeExtensions
    {
        public static IEdge<int> FindEdgeIfExists(this Node from, Node to)
        {
            return from.Edges.FirstOrDefault(l =>
                l.Start.Equals(from) && l.End.Equals(to)
                || l.Start.Equals(to) && l.End.Equals(from));
        }
    }
}
