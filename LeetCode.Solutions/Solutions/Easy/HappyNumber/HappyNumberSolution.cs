using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Solutions.Easy.HappyNumber
{
    public class HappyNumberSolution
    {
        private readonly DigitSeparator _separator = new();
        private readonly HashSet<int> _seenNumbers = [];
        private readonly Dictionary<int, int> _squares = [];

        public bool IsHappy(int n)
        {
            while (true) {
                var digits = _separator.GetDigits(n);
                n = digits.Select(d => GetSquare(d)).Sum();

                if (n == 1)
                {
                    return true;
                }

                if (_seenNumbers.Contains(n))
                {
                    return false;
                }

                _seenNumbers.Add(n);
            }
        }

        private int GetSquare(int n)
        {
            if (_squares.ContainsKey(n))
            {
                return _squares[n];
            }

            var square = n * n;

            _squares[n] = square;

            return square;
        }
    }

    public class DigitSeparator
    {
        public int[] GetDigits(int n)
        {
            var digits = new List<int>();

            while (n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            return [.. digits];
        }
    }
}
