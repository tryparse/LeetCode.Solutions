using System;

namespace LeetCode.Solutions.Easy
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            var shouldIncrement = true;

            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (shouldIncrement)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                        shouldIncrement = true;
                    }
                    else
                    {
                        digits[i] = digits[i] + 1;
                        shouldIncrement = false;
                    }
                }
                else
                {
                    break;
                }
            }

            if (shouldIncrement)
            {
                Array.Resize(ref digits, digits.Length + 1);

                Array.Copy(digits, 0, digits, 1, digits.Length - 1);

                digits[0] = 1;
            }

            return digits;
        }
    }
}
