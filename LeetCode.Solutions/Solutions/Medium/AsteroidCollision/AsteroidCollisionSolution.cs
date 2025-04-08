using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Solutions.Medium.AsteroidCollision
{
    public class AsteroidCollisionSolution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();

            for (var i = 0; i < asteroids.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(asteroids[i]);
                    continue;
                }

                var current = asteroids[i];

                while (stack.TryPeek(out var previous) && IsCollide(previous, current))
                {
                    stack.Pop();
                    current = ResolveCollision(previous, current);

                    if (current == 0) break;
                }

                if (current != 0)
                {
                    stack.Push(current);
                }
            }

            var result = stack.ToArray();
            Array.Reverse(result);

            return result;
        }

        private static bool IsCollide(int a, int b) => a > 0 && b < 0;

        private static int ResolveCollision(int a, int b)
        {
            if (a == b)
            {
                return 0;
            }

            var absA = Math.Abs(a);
            var absB = Math.Abs(b);

            if (absA == absB)
            {
                return 0;
            }

            return absA > absB
                ? a
                : b;
        }
    }
}
