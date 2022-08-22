using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Common.Dijkstra.Generic
{
    public class DijkstraGraph<TLength>
        where TLength : IComparable<TLength>
    {
        private readonly List<INode<TLength>> _nodes;
        private readonly List<IEdge<TLength>> _edges;
        private int _visitedNodeCount;

        public IEnumerable<INode<TLength>> Nodes => _nodes;
        public IEnumerable<IEdge<TLength>> Edges => _edges;

        public DijkstraGraph(IEnumerable<INode<TLength>> nodes, IEnumerable<IEdge<TLength>> edges)
        {
            _nodes = nodes != null ? nodes.ToList() : new List<INode<TLength>>(10000);
            _edges = edges != null ? edges.ToList() : new List<IEdge<TLength>>(10000 * 4);
        }

        public DijkstraGraph() : this(null, null)
        {

        }

        public void AddNode(INode<TLength> node) => _nodes.Add(node);

        public void AddEdge(IEdge<TLength> edge) => _edges.Add(edge);

        public void CalculateDistance(
            INode<TLength> startNode,
            DijkstraDistanceCalculationType calculationType = DijkstraDistanceCalculationType.ShortestPath)
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

            while (_visitedNodeCount < _nodes.Count)
            {
                ProcessNode(calculationType, currentNode);
                SetNodeVisited(currentNode);

                if (currentNode.ID == lastNodeId)
                {
                    return;
                }

                currentNode = _nodes
                    .Where(x => !x.IsVisited)
                    .OrderBy(x => x.Distance)
                    .FirstOrDefault();
            }
        }

        private void SetNodeVisited(INode<TLength> currentNode)
        {
            currentNode.Visit();
            _visitedNodeCount++;
        }

        private void ProcessNode(
            DijkstraDistanceCalculationType calculationType,
            INode<TLength> currentNode)
        {
            var edges = currentNode.Edges.OrderBy(e => e.Length);

            foreach (var edge in edges)
            {
                var neighbour = edge.Start.ID == currentNode.ID
                    ? edge.End
                    : edge.Start;

                if (neighbour.IsVisited)
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
