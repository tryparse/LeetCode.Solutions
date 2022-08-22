using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Common.Dijkstra.Generic
{
    public interface INode<TLength> : IEntityWithID where TLength : IComparable<TLength>
    {
        TLength Distance { get; set; }
        IEnumerable<IEdge<TLength>> Edges { get; }
        void SetDistanceToZero();
        void AddEdge(IEdge<TLength> link);
        TLength SumDistance(TLength add);
        bool IsVisited { get; }
        void Visit();
    }
}
