namespace LeetCode.Solutions.Common.Dijkstra
{
    public class GridNode : Node
    {
        public int X { get; }
        public int Y { get; }

        public GridNode(int id, int x, int y) : base(id)
        {
            X = x;
            Y = y;
        }
    }
}
