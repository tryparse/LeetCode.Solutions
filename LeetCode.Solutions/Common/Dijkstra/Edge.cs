using LeetCode.Solutions.Common.Dijkstra.Generic;

namespace LeetCode.Solutions.Common.Dijkstra
{
    public class Edge : IEdge<int>
    {
        public INode<int> Start { get; }

        public INode<int> End { get; }

        public int Length { get; }

        public Edge(INode<int> start, INode<int> end, int length)
        {
            Start = start;
            End = end;
            Length = length;

            Start.AddEdge(this);
            End.AddEdge(this);
        }
    }
}
