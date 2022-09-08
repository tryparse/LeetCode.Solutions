using System;
using System.Diagnostics;
using LeetCode.Solutions.Common.BinaryTree;
using LeetCode.Solutions.Common.Dijkstra;
using LeetCode.Solutions.Common.Dijkstra.Generic;
using LeetCode.Solutions.Common.Dijkstra.HeightGrid;
using LeetCode.Solutions.Solutions.ConstructStringFromBinaryTree;

namespace DebugSolutionRunner
{
    public static class Program
    {
        public static void Main()
        {
            //var solution = new ConstructStringFromBinaryTreeSolution();

            var values = new int?[] { 1, 2, 3, null, 4 };
            var expected = "1(2()(4))(3)";

            var root = values.ToTreeNode();

            Console.WriteLine($"Actual={root.ConvertToString()}");
            Console.WriteLine($"Expected={expected}");

            Console.WriteLine("press any key");
            Console.ReadKey(true);
        }

        private static void WikiDijkstraExample()
        {
            var dijkstra = new DijkstraGraph<int>();

            var n1 = new Node(1);
            var n2 = new Node(2);
            var n3 = new Node(3);
            var n4 = new Node(4);
            var n5 = new Node(5);
            var n6 = new Node(6);

            dijkstra.AddNode(n1);
            dijkstra.AddNode(n2);
            dijkstra.AddNode(n3);
            dijkstra.AddNode(n4);
            dijkstra.AddNode(n5);
            dijkstra.AddNode(n6);

            dijkstra.AddEdge(new Edge(n1, n2, 7));
            dijkstra.AddEdge(new Edge(n1, n3, 9));
            dijkstra.AddEdge(new Edge(n1, n6, 14));
            dijkstra.AddEdge(new Edge(n2, n3, 10));
            dijkstra.AddEdge(new Edge(n2, n4, 15));
            dijkstra.AddEdge(new Edge(n3, n4, 11));
            dijkstra.AddEdge(new Edge(n3, n6, 2));
            dijkstra.AddEdge(new Edge(n4, n5, 6));
            dijkstra.AddEdge(new Edge(n5, n6, 9));

            dijkstra.CalculateDistance(n1);

            foreach (var n in dijkstra.Nodes)
            {
                var id = (IEntityWithID)n;
                Console.WriteLine($"ID={id.ID}, {n.Distance}");
            }
        }
    }
}
