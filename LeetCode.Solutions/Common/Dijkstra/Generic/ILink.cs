using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Common.Dijkstra.Generic
{
    public interface IEdge<TLength> where TLength : IComparable<TLength>
    {
        INode<TLength> Start { get; }
        INode<TLength> End { get; }
        HashSet<INode<TLength>> Nodes => new() { Start, End };
        TLength Length { get; }
    }
}
