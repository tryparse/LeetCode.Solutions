using LeetCode.Solutions.Common.NTree;

namespace DebugSolutionRunner
{
    public static class Program
    {
        public static void Main()
        {
            //var solution = new ConstructStringFromBinaryTreeSolution();

            var input = new int?[] { 1, null, 3, 2, 4, null, 5, 6 };

            var root = input.ToTree();

            Console.WriteLine("press any key");
            Console.ReadKey(true);
        }
    }
}
