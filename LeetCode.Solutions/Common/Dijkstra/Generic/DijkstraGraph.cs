using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Common.Dijkstra.Generic
{
    public class DijkstraGraph<TLength>
        where TLength : IComparable<TLength>
    {
        private readonly List<INode<TLength>> _nodes;
        private readonly Dictionary<int, INode<TLength>> _visitedNodes;
        private readonly List<IEdge<TLength>> _edges;

        public IEnumerable<INode<TLength>> Nodes => _nodes;
        public IEnumerable<IEdge<TLength>> Edges => _edges;

        public DijkstraGraph(IEnumerable<INode<TLength>> nodes, IEnumerable<IEdge<TLength>> edges)
        {
            _nodes = nodes != null ? nodes.ToList() : new List<INode<TLength>>();
            _visitedNodes = new Dictionary<int, INode<TLength>>();
            _edges = edges != null ? edges.ToList() : new List<IEdge<TLength>>();
        }

        public DijkstraGraph() : this(null, null)
        {

        }

        public void AddNode(INode<TLength> node) => _nodes.Add(node);

        public void AddEdge(IEdge<TLength> edge) => _edges.Add(edge);

        public void CalculateDistance(INode<TLength> startNode, DijkstraDistanceCalculationType calculationType = DijkstraDistanceCalculationType.ShortestPath)
        {
            if (!_nodes.Any())
            {
                return;
            }

            if (null == startNode)
            {
                startNode = _nodes.First();
            }

            startNode.SetDistanceToZero();

            INode<TLength> currentNode = startNode;
            var lastNodeId = _nodes.LastOrDefault().ID;

            while (_visitedNodes.Count < _nodes.Count)
            {
                var edges = currentNode.Edges
                                    .OrderBy(e => e.Length);
                ProcessNode(calculationType, currentNode, edges);

                _visitedNodes.Add(currentNode.ID, currentNode);

                if (currentNode.ID == lastNodeId)
                {
                    break;
                }

                currentNode = _nodes
                    .Where(x => !_visitedNodes.ContainsKey(x.ID))
                    .OrderBy(x => x.Distance)
                    .FirstOrDefault();
            }
        }

        private void ProcessNode(DijkstraDistanceCalculationType calculationType, INode<TLength> currentNode, IOrderedEnumerable<IEdge<TLength>> edges)
        {
            foreach (var edge in edges)
            {
                var neighbour = edge.Start.ID == currentNode.ID
                    ? edge.End
                    : edge.Start;

                if (_visitedNodes.ContainsKey(neighbour.ID))
                {
                    continue;
                }

                TLength newDistance;

                switch (calculationType)
                {
                    case DijkstraDistanceCalculationType.MinEffort:
                        {
                            newDistance = edge.Length.CompareTo(currentNode.Distance) > 0
                                ? edge.Length
                                : currentNode.Distance;

                            break;
                        }
                    default:
                        {
                            newDistance = currentNode.SumDistance(edge.Length);

                            break;
                        }
                }

                neighbour.Distance = neighbour.Distance.CompareTo(newDistance) > 0
                                ? newDistance
                                : neighbour.Distance;
            }
        }
    }
}
