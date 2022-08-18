using System.Collections.Generic;
using LeetCode.Solutions.Common.Dijkstra.Generic;

namespace LeetCode.Solutions.Common.Dijkstra.HeightGrid
{
    public class DijkstraHeightGridGraph : DijkstraGraph<int>
    {
        public DijkstraHeightGridGraph(
            IEnumerable<HeightGridNode> nodes,
            IEnumerable<Edge> edges,
            int width,
            int height) : base(nodes, edges)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }

        Dictionary<int[], HeightGridNode> _coordinateCache;

        public HeightGridNode this[int x, int y]
        {
            get
            {
                if (x >= Width || y >= Height) return null;

                var coord = new int[2] { x, y };

                if (_coordinateCache != null)
                {
                    if (_coordinateCache.ContainsKey(coord))
                    {
                        return _coordinateCache[coord];
                    }
                }
                else
                {
                    _coordinateCache = new Dictionary<int[], HeightGridNode>();
                }

                foreach (var node in Nodes)
                {
                    if (node is HeightGridNode hgn
                        && hgn.X == x
                        && hgn.Y == y)
                    {
                        _coordinateCache.Add(coord, hgn);

                        return hgn;
                    }
                }

                return null;
            }
        }

        public HeightGridNode FindBottomNeighbourIfExists(HeightGridNode node)
        {
            return this[node.X, node.Y + 1];
        }

        public HeightGridNode FindRightNeighbourIfExists(HeightGridNode node)
        {
            return this[node.X + 1, node.Y];
        }
    }
}
