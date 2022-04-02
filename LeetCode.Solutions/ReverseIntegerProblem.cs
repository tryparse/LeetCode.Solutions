using System;

namespace LeetCode.Solutions
{
    // https://leetcode.com/problems/reverse-integer/
    public class ReverseIntegerProblem
    {
        public int Reverse(int x)
        {
            if (x == 0)
            {
                return x;
            }
            else if (x == int.MinValue)
            {
                return 0;
            }

            var a = Math.Abs(x)
                .ToString()
                .ToCharArray();

            Array.Reverse(a);

            var result = new string(a);

            if (result.StartsWith("0"))
            {
                result = result.Substring(1, result.Length - 1);
            }

            if (x < 0)
            {
                result = "-" + result;
            }

            int.TryParse(result, out var r);

            return r;
        }
    }
}
