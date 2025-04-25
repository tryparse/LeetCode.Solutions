using System.Collections.Generic;

namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/excel-sheet-column-title/description/
    public class ExcelSheetColumnTitleSolution
    {
        private const byte A = (byte)'A';
        private const int LettersNumber = 26;

        public string ConvertToTitle(int columnNumber)
        {
            if (columnNumber <= LettersNumber)
            {
                return new string(GetChar(columnNumber - 1), 1);
            }

            var stack = new Stack<char>();

            while (columnNumber > 0)
            {
                columnNumber--;

                var remainder = columnNumber % LettersNumber;

                stack.Push(GetChar(remainder));

                columnNumber /= LettersNumber;
            }

            return new string([.. stack]);
        }

        private char GetChar(int n) => (char)(A + n);
    }
}

// 27 AA
// 28 AB
// 26
// 2 B
