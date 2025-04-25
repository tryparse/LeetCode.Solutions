namespace LeetCode.Solutions.Easy
{
    public class FibonachiNumberSolution
    {
        public int Fib(int n)
        {
            if (n == 0
                || n == 1)
            {
                return n;
            }

            var prev1 = 0;
            var prev2 = 1;
            var result = 0;

            for (var i = 2; i <= n; i++)
            {
                result = prev1 + prev2;
                prev1 = prev2;
                prev2 = result;
            }

            return result;
        }
    }
}
