// See https://aka.ms/new-console-template for more information
using static LeetCode.Solutions.PathWithMinimumEfforts.PathWithMinimumEffort;
//[[4,3,4,10,5,5,9,2],[10,8,2,10,9,7,5,6],[5,8,10,10,10,7,4,2],[5,1,3,1,1,3,1,9],[6,4,10,6,10,9,4,6]]
var heights = new int[][]
{
    new int[] { 4,  3,  4, 10,  5, 5, 9, 2 },
    new int[] { 10, 8,  2, 10,  9, 7, 5, 6 },
    new int[] { 5,  8, 10, 10, 10, 7, 4, 2 },
    new int[] { 5,  1,  3,  1,  1, 3, 1, 9 },
    new int[] { 6,  4, 10,  6, 10, 9, 4, 6 }
};

var graph = Graph.Build(heights, 0, 0);

graph.CalculateNodesDistance();

foreach (var n in graph.Nodes)
{
    Console.WriteLine(n);
}

Console.WriteLine();

foreach (var l in graph.Links)
{
    Console.WriteLine(l);
}

var shortest = graph.GetShortestPath().ToList();
var maxDifference = 0;

for (var i = 0; i < shortest.Count - 1; i++)
{
    maxDifference = Math.Max(maxDifference, Math.Abs(shortest[i].Height - shortest[i + 1].Height));
}

Console.WriteLine(string.Join("->", shortest.Select(x => $"{{{x.ID}}}")));
Console.WriteLine("maxDifference=" + maxDifference);

Console.WriteLine("press any key");
Console.ReadKey(true);
