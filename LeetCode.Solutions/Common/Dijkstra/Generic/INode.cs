using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Common.Dijkstra.Generic
{
    public interface INode<TLength> where TLength : IComparable<TLength>
    {
        TLength Distance { get; set; }
        IEnumerable<IEdge<TLength>> Edges { get; }
        void SetInitialDistance();
        void SetDistanceToZero();
        bool TryAddEdge(IEdge<TLength> link);
        TLength SumDistance(TLength add);
    }
}
