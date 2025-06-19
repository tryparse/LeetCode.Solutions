using LeetCode.Learning.NTree;
using Shouldly;

namespace LeetCode.Learning.Tests
{
    public class Sandbox
    {
        [Fact]
        public void Run()
        {
            Node<char> g = new('G');
            Node<char> f = new('F', [g]);
            Node<char> e = new('E');
            Node<char> d = new('D', [g]);
            Node<char> c = new('C', [e, f]);
            Node<char> b = new('B', [e]);
            Node<char> root = new('A', [b, c, d]);

            var bfs = new BreadthFirstSearch<char>();

            var steps = bfs.Search(root, g);
            steps.ShouldBe(3);
        }

    }
}
