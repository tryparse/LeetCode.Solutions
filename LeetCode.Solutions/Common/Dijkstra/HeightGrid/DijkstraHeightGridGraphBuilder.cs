using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Common.Dijkstra.HeightGrid
{
    public class DijkstraHeightGridGraphBuilder
    {
        readonly Dictionary<int, Dictionary<int, HeightGridNode>> _nodesDict = new();

        public DijkstraHeightGridGraph Build(int[][] grid)
        {
            var edges = new List<Edge>();

            var width = grid[0].GetLength(0);
            var height = grid.GetLength(0);

            for (var j = 0; j < height; j++)
            {
                for (var i = 0; i < width; i++)
                {
                    var node = new HeightGridNode(i + j * width, i, j, grid[j][i]);

                    if (!_nodesDict.ContainsKey(i))
                    {
                        _nodesDict.Add(i, new Dictionary<int, HeightGridNode>());
                        _nodesDict[i].Add(j, node);
                    }
                    else
                    {
                        if (!_nodesDict[i].ContainsKey(j))
                        {
                            _nodesDict[i].Add(j, node);
                        }
                    }
                }
            }

            var nodes = _nodesDict.Values.SelectMany(x => x.Values);

            foreach (var node in nodes)
            {
                AddNodesNeighbours(edges, width, height, node);
            }

            return new DijkstraHeightGridGraph(
                nodes,
                edges,
                grid[0].GetLength(0),
                grid.GetLength(0));
        }

        private void AddNodesNeighbours(List<Edge> edges, int width, int height, HeightGridNode node)
        {
            if (node.X > 0)
            {
                TryAddNeighbour(edges, node, node.X - 1, node.Y);
            }

            if (node.X < width - 1)
            {
                TryAddNeighbour(edges, node, node.X + 1, node.Y);
            }

            if (node.Y > 0)
            {
                TryAddNeighbour(edges, node, node.X, node.Y - 1);
            }

            if (node.Y < height - 1)
            {
                TryAddNeighbour(edges, node, node.X, node.Y + 1);
            }
        }

        private bool TryAddNeighbour(
            List<Edge> edges,
            HeightGridNode currentNode,
            int neighbourX,
            int neighbourY)
        {
            HeightGridNode neighbour;

            if (!_nodesDict.ContainsKey(neighbourX))
            {
                return false;
            }

            if (!_nodesDict[neighbourX].ContainsKey(neighbourY))
            {
                return false;
            }

            neighbour = _nodesDict[neighbourX][neighbourY];

            edges.Add(new Edge(currentNode, neighbour, Math.Abs(currentNode.Height - neighbour.Height)));

            return true;
        }
    }
}
