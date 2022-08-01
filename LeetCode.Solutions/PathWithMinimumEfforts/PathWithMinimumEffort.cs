using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.PathWithMinimumEfforts
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>https://leetcode.com/problems/path-with-minimum-effort/</remarks>
    public class PathWithMinimumEffort
    {
        public int MinimumEffortPath(int[][] heights)
        {
            // [1,2,2]
            // [3,8,2]
            // [5,3,5]
            var graph = Graph.Build(heights, 0, 0);

            graph.CalculateNodesDistance();

            var shortest = graph.GetShortestPath().ToList();
            var maxDifference = 0;

            for (var i = 0; i < shortest.Count - 1; i++)
            {
                maxDifference = Math.Max(maxDifference, Math.Abs(shortest[i].Height - shortest[i + 1].Height));
            }

            return maxDifference;
        }

        public class Node
        {
            private static int _id;
            public int ID { get; }
            public int X { get; }
            public int Y { get; }
            public int Height { get; }
            public int ShortestDistance { get; set; }
            public bool IsVisited { get; set; }
            public int? VisitOrder { get; set; }

            public HashSet<Node> NeighbourNodes { get; }
            public HashSet<NodeLink> Links { get; }

            public Node(int x, int y, int height)
            {
                ID = _id++;

                X = x;
                Y = y;
                Height = height;

                NeighbourNodes = new HashSet<Node>();
                Links = new HashSet<NodeLink>();

                ShortestDistance = int.MaxValue;
            }

            public override string ToString()
            {
                return $"{{ID={ID}, X={X}, Y={Y}, Height={Height}, ShortestPath={ShortestDistance}, Order={VisitOrder}}}" +
                    $" Neighbours=[{string.Join(",", NeighbourNodes.Select(x => x.ID))}]";
            }
        }

        public class NodeLink
        {
            public Node StartNode { get; }
            public Node EndNode { get; }
            public int Length { get; }
            public HashSet<Node> Nodes { get; }

            public NodeLink(Node startNode, Node endNode)
            {
                if (startNode?.ID == endNode?.ID)
                {
                    throw new ArgumentException("Link can't be created for same node");
                }

                StartNode = startNode ?? throw new ArgumentNullException(nameof(startNode));
                EndNode = endNode ?? throw new ArgumentNullException(nameof(endNode));

                Length = Math.Abs(StartNode.Height - EndNode.Height);

                startNode.Links.Add(this);
                endNode.Links.Add(this);

                Nodes = new HashSet<Node> { startNode, endNode };
            }

            public override string ToString()
            {
                return $"{{From={StartNode.ID} To={EndNode.ID}, Length={Length}}}";
            }
        }

        public class Graph
        {
            private int _visitOrder;
            private int[][] _heights;
            private List<Node> _nodes;
            private List<NodeLink> _links;

            private int _startX;
            private int _startY;
            private int _targetX;
            private int _targetY;

            public List<Node> Nodes => _nodes;
            public List<NodeLink> Links => _links;

            private Graph(int startX, int startY, int targetX, int targetY)
            {
                _nodes = new List<Node>();
                _links = new List<NodeLink>();

                _startX = startX;
                _startY = startY;
                _targetX = targetX;
                _targetY = targetY;
            }

            public static Graph Build(int[][] heights, int startX, int startY, int? targetX = null, int? targetY = null)
            {
                if (heights is null)
                {
                    throw new ArgumentNullException(nameof(heights));
                }

                targetX = targetX.HasValue
                    ? targetX
                    : heights.GetUpperBound(0);

                targetY = targetY.HasValue
                    ? targetY
                    : heights[0].GetUpperBound(0);

                var graph = new Graph(startX, startY, targetX.Value, targetY.Value)
                {
                    _heights = heights
                };

                CreateNodes(heights, graph);

                foreach (var node in graph.Nodes)
                {
                    graph.FindNeighboursAndLinks(node);
                }

                return graph;
            }

            private static void CreateNodes(int[][] heights, Graph graph)
            {
                for (var j = 0; j < heights.GetLength(0); j++)
                {
                    for (var i = 0; i < heights[j].GetLength(0); i++)
                    {
                        graph.TryAddNode(heights, j, i);
                    }
                }
            }

            private bool TryAddNode(int[][] heights, int x, int y)
            {
                if (IsNodeAlreadyAdded(x, y))
                {
                    return false;
                }

                var currentNode = new Node(x, y, heights[x][y]);
                _nodes.Add(currentNode);

                return true;
            }

            private void FindNeighboursAndLinks(Node currentNode)
            {
                TryAddNeighbour(currentNode, currentNode.X - 1, currentNode.Y);
                TryAddNeighbour(currentNode, currentNode.X + 1, currentNode.Y);
                TryAddNeighbour(currentNode, currentNode.X, currentNode.Y - 1);
                TryAddNeighbour(currentNode, currentNode.X, currentNode.Y + 1);
            }

            private bool TryAddNeighbour(Node currentNode, int neighbourX, int neighbourY)
            {
                var neighbour = _nodes.FirstOrDefault(n => n.X == neighbourX && n.Y == neighbourY);

                if (null == neighbour)
                {
                    return false;
                }

                AddNeighbours(currentNode, neighbour);
                TryAddLink(currentNode, neighbour);

                return false;
            }

            private static void AddNeighbours(Node currentNode, Node bottom)
            {
                currentNode.NeighbourNodes.Add(bottom);
                bottom.NeighbourNodes.Add(currentNode);
            }

            private bool TryAddLink(Node node1, Node node2)
            {
                if (IsLinkAlreadyAdded(node1.ID, node2.ID))
                {
                    return false;
                }

                _links.Add(new NodeLink(node1, node2));

                return true;
            }

            private bool IsLinkAlreadyAdded(int firstId, int secondId)
            {
                return _links
                    .Any(x =>
                        (x.StartNode.ID == firstId && x.EndNode.ID == secondId)
                        || (x.StartNode.ID == secondId && x.EndNode.ID == firstId));
            }

            private bool IsNodeAlreadyAdded(int x, int y)
            {
                return _nodes.Any(n => n.X == x && n.Y == y);
            }

            public void CalculateNodesDistance()
            {
                foreach (var node in _nodes)
                {
                    node.ShortestDistance = int.MaxValue;
                }

                while (_nodes.Any(x => !x.IsVisited))
                {
                    var currentNode = FindNearestNotVisitedNode(GetLastVisitedNode());

                    if (IsFirstNode())
                    {
                        currentNode.ShortestDistance = 0;
                    }

                    foreach (var link in currentNode.Links
                        .OrderBy(link => link.Length)
                        .ThenBy(link => link.StartNode.ID)
                        .ThenBy(link => link.EndNode.ID))
                    {
                        var neighbourNode = link.StartNode.ID == currentNode.ID
                            ? link.EndNode
                            : link.StartNode;

                        if (neighbourNode.IsVisited)
                        {
                            continue;
                        }

                        var path = currentNode.ShortestDistance + link.Length;

                        neighbourNode.ShortestDistance = Math.Min(neighbourNode.ShortestDistance, path);
                    }

                    currentNode.IsVisited = true;
                    currentNode.VisitOrder = _visitOrder++;
                }
            }

            private Node FindNearestNotVisitedNode(Node lastVisitedNode)
            {
                if (null == lastVisitedNode)
                {
                    return GetFirstNode();
                }

                var result = lastVisitedNode.Links
                    .OrderBy(x => x.Length)
                    .SelectMany(x => x.Nodes)
                    .Where(x => x.ID != lastVisitedNode.ID && !x.IsVisited)
                    .Distinct()
                    .FirstOrDefault();

                if (null == result)
                {
                    result = Nodes.FirstOrDefault(x => !x.IsVisited);
                }

                return result;
            }

            private bool IsFirstNode()
            {
                return !_nodes.Any(x => x.IsVisited);
            }

            private Node GetFirstNode()
            {
                return _nodes.FirstOrDefault(node => node.X == 0 && node.Y == 0);
            }

            private Node GetLastVisitedNode()
            {
                if (IsFirstNode())
                {
                    return null;
                }

                return _nodes
                    .Where(x => x.VisitOrder.HasValue)
                    .OrderByDescending(x => x.VisitOrder)
                    .FirstOrDefault();
            }

            public HashSet<Node> GetShortestPath()
            {
                var result = new HashSet<Node>();

                var current = GetFirstNode();

                result.Add(current);

                int x = current.X;
                int y = current.Y;

                while (x != _targetX || y != _targetY)
                {
                    current = current.Links
                        .OrderBy(x => x.Length)
                        .SelectMany(x => x.Nodes)
                        .Where(x => x.ID != current.ID && !result.Contains(x))
                        .Distinct()
                        .FirstOrDefault();

                    result.Add(current);

                    x = current.X;
                    y = current.Y;
                }

                return result;
            }
        }
    }
}
