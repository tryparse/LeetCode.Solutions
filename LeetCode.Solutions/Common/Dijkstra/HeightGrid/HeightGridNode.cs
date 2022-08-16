namespace LeetCode.Solutions.Common.Dijkstra.HeightGrid
{
    public class HeightGridNode : GridNode
    {
        public int Height { get; }

        public HeightGridNode(int id, int x, int y, int height) : base(id, x, y)
        {
            Height = height;
        }
    }
}
