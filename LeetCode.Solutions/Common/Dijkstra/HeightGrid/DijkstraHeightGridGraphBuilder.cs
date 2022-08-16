using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Common.Dijkstra.HeightGrid
{
    public class DijkstraHeightGridGraphBuilder
    {
        public DijkstraHeightGridGraph Build(int[][] grid)
        {
            var stopwatch = Stopwatch.StartNew();

            try
            {
                var nodes = new HashSet<HeightGridNode>();
                var edges = new ConcurrentBag<Edge>();

                var width = grid[0].GetLength(0);
                var height = grid.GetLength(0);

                for (var j = 0; j < height; j++)
                {
                    for (var i = 0; i < width; i++)
                    {
                        nodes.Add(new HeightGridNode(i + j * width, i, j, grid[j][i]));
                    }
                }

                Parallel.ForEach(nodes, node =>
                {
                    Console.WriteLine(node.ID);
                    TryAddNeighbour(nodes, edges, node, node.X - 1, node.Y);
                    TryAddNeighbour(nodes, edges, node, node.X + 1, node.Y);
                    TryAddNeighbour(nodes, edges, node, node.X, node.Y - 1);
                    TryAddNeighbour(nodes, edges, node, node.X, node.Y + 1);
                });

                return new DijkstraHeightGridGraph(
                    nodes,
                    edges,
                    grid[0].GetLength(0),
                    grid.GetLength(0));
            }
            finally
            {
                stopwatch.Stop();
                Console.WriteLine($"{nameof(DijkstraHeightGridGraphBuilder)}.{nameof(Build)}: {stopwatch.ElapsedMilliseconds} ms");
            }
        }

        private bool TryAddNeighbour(
            HashSet<HeightGridNode> nodes,
            ConcurrentBag<Edge> edges,
            HeightGridNode currentNode,
            int neighbourX,
            int neighbourY)
        {
            var stopwatch = Stopwatch.StartNew();

            try
            {
                var neighbour = nodes.FirstOrDefault(n => n.X == neighbourX && n.Y == neighbourY);

                if (null == neighbour)
                {
                    return false;
                }

                edges.Add(new Edge(currentNode, neighbour, Math.Abs(currentNode.Height - neighbour.Height)));

                return true;
            }
            finally
            {
                stopwatch.Stop();
                Console.WriteLine($"{nameof(DijkstraHeightGridGraphBuilder)}.{nameof(TryAddNeighbour)}: {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
