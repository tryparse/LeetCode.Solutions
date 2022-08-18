using System.Collections.Generic;
using System.Linq;
using LeetCode.Solutions.Common.Dijkstra.Generic;

namespace LeetCode.Solutions.Common.Dijkstra
{
    public class Node : INode<int>
    {
        public int ID { get; }

        public int Distance { get; set; }

        private readonly List<IEdge<int>> _edges;

        public IEnumerable<IEdge<int>> Edges => _edges;

        public Node(int id)
        {
            ID = id;
            _edges = new List<IEdge<int>>();

            SetInitialDistance();
        }
        private void SetInitialDistance()
        {
            Distance = int.MaxValue;
        }

        public void AddEdge(IEdge<int> edge)
        {
            _edges.Add(edge);
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
