using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Common.Dijkstra.Generic
{
    public class DijkstraGraph<TLength>
        where TLength : IComparable<TLength>
    {
        private readonly HashSet<INode<TLength>> _nodes;
        private readonly HashSet<INode<TLength>> _visitedNodes;
        private readonly HashSet<IEdge<TLength>> _edges;

        public IEnumerable<INode<TLength>> Nodes => _nodes;
        public IEnumerable<IEdge<TLength>> Edges => _edges;

        public DijkstraGraph(IEnumerable<INode<TLength>> nodes, IEnumerable<IEdge<TLength>> edges)
        {
            _nodes = nodes != null ? nodes.ToHashSet() : new HashSet<INode<TLength>>();
            _visitedNodes = new HashSet<INode<TLength>>();
            _edges = edges != null ? edges.ToHashSet() : new HashSet<IEdge<TLength>>();
        }

        public DijkstraGraph() : this(null, null)
        {

        }

        public bool TryAddNode(INode<TLength> node) => _nodes.Add(node);

        public bool TryAddEdge(IEdge<TLength> edge) => _edges.Add(edge);

        public void CalculateDistance(INode<TLength> startNode, DijkstraDistanceCalculationType calculationType = DijkstraDistanceCalculationType.ShortestPath)
        {
            if (!_nodes.Any()
                || !_edges.Any())
            {
                return;
            }

            if (null == startNode)
            {
                startNode = _nodes.First();
            }

            foreach (var node in _nodes)
            {
                node.SetInitialDistance();
            }

            startNode.SetDistanceToZero();

            INode<TLength> currentNode = startNode;

            while (_visitedNodes.Count < _nodes.Count)
            {
                foreach (var edge in currentNode.Edges
                    .OrderBy(e => e.Length))
                {
                    var neighbour = edge.Start.Equals(currentNode)
                        ? edge.End
                        : edge.Start;

                    if (_visitedNodes.Contains(neighbour))
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

                                neighbour.Distance = neighbour.Distance.CompareTo(newDistance) > 0
                                    ? newDistance
                                    : neighbour.Distance;

                                break;
                            }
                        default:
                            {
                                newDistance = currentNode.SumDistance(edge.Length);

                                neighbour.Distance = neighbour.Distance.CompareTo(newDistance) > 0
                                    ? newDistance
                                    : neighbour.Distance;

                                break;
                            }
                    }

                    
                }

                _visitedNodes.Add(currentNode);

                currentNode = _nodes
                    .Where(x => !_visitedNodes.Contains(x))
                    .OrderBy(x => x.Distance)
                    .FirstOrDefault();
            }
        }
    }
}
