using System.Collections.Generic;
using System.Linq;
using LeetCode.Solutions.Common.Dijkstra.Generic;

namespace LeetCode.Solutions.Common.Dijkstra
{
    public class Node : INode<int>, IEntityWithID
    {
        public int ID { get; }

        public int Distance { get; set; }

        private readonly HashSet<IEdge<int>> _edges;

        public IEnumerable<IEdge<int>> Edges => _edges;

        public Node(int id)
        {
            ID = id;
            _edges = new HashSet<IEdge<int>>();
        }
        public void SetInitialDistance()
        {
            Distance = int.MaxValue;
        }

        public bool TryAddEdge(IEdge<int> edge)
        {
            return _edges.Add(edge);
        }

        public void SetDistanceToZero()
        {
            Distance = 0;
        }

        public int SumDistance(int add)
        {
            return Distance + add;
        }
    }
}
