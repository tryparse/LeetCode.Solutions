using System;

namespace LeetCode.Solutions.Common.Dijkstra.HeightGrid
{
    public class DijkstraHeightGridGraphVisualizer
    {
        private const char PADDING_CHAR = ' ';
        private const int NODE_PADDING = 8;
        private const int HORIZONTAL_LINK_PADDING = 8;
        private const int VERTICAL_LINK_PADDING = NODE_PADDING + HORIZONTAL_LINK_PADDING;

        private readonly DijkstraHeightGridGraph _graph;

        public DijkstraHeightGridGraphVisualizer(DijkstraHeightGridGraph graph)
        {
            _graph = graph ?? throw new ArgumentNullException(nameof(graph));
        }

        public void VisualizeToConsole()
        {
            Console.SetCursorPosition(0, 0);

            for (var y = 0; y < _graph.Height; y++)
            {
                for (var x = 0; x < _graph.Width; x++)
                {
                    var node = _graph[x, y];

                    Console.Write(GetNodeInfo(node)
                        //+ "("
                        //+ GetNodeHeight(node) + GetDistance(node)
                        //+ ")")
                        .PadRight(NODE_PADDING, PADDING_CHAR));

                    var right = _graph.FindRightNeighbourIfExists(node);

                    PrintRightLink(node, right);
                }

                Console.WriteLine();

                for (var x = 0; x < _graph.Width; x++)
                {
                    var node = _graph[x, y];
                    var bottom = _graph.FindBottomNeighbourIfExists(node);

                    PrintBottomLink(node, bottom);
                }

                Console.WriteLine();
            }
        }

        private static string GetNodeInfo(HeightGridNode node)
        {
            return $"[{node.ID}]";
        }

        private static string GetNodeHeight(HeightGridNode node)
        {
            return $"h={node.Height}";
        }

        private static string GetDistance(HeightGridNode node)
        {
            return $"/d={(node.Distance == int.MaxValue || node.Distance == int.MinValue ? "?" : node.Distance.ToString())}";
        }

        private static void PrintBottomLink(Node node, Node bottom)
        {
            if (null != bottom)
            {
                var link = node.FindEdgeIfExists(bottom);
                Console.Write($"|{link?.Length}|".PadRight(VERTICAL_LINK_PADDING, PADDING_CHAR));
            }
        }

        private static void PrintRightLink(Node node, Node right)
        {
            if (null != right)
            {
                var link = node.FindEdgeIfExists(right);
                Console.Write($"={link?.Length}=".PadRight(HORIZONTAL_LINK_PADDING, PADDING_CHAR));
            }
        }
    }
}
