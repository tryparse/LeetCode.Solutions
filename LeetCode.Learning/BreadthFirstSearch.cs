using LeetCode.Learning.NTree;

namespace LeetCode.Learning
{
    public class BreadthFirstSearch<T>
    {
        public int Search(Node<T> root, Node<T> target)
        {
            Queue<Node<T>> queue = new();
            HashSet<Node<T>> visited = [];

            int step = 0;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; ++i)
                {
                    Node<T> cursor = queue.Dequeue();

                    if (cursor == target)
                    {
                        return step;
                    }

                    if (cursor?.Children == null)
                    {
                        continue;
                    }

                    foreach (var next in cursor.Children)
                    {
                        if (visited.Contains(next))
                        {
                            continue;
                        }

                        queue.Enqueue(next);
                        visited.Add(next);
                    }

                    visited.Add(cursor);
                }

                step++;
            }

            return -1;
        }
    }
}
