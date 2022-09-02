using System;

namespace LeetCode.Solutions.PalindromeNumber
{
    // https://leetcode.com/problems/palindrome-number/
    public class PalindromeNumberProblem
    {
        public bool IsPalindrome(int x)
        {
            if (x == 0)
            {
                return true;
            }
            else if (x < 0)
            {
                return false;
            }
            else
            {
                var arr = x.ToString()
                    .ToCharArray();

                for (var i = 0; i < arr.Length / 2; i++)
                {
                    if (arr[i] != arr[arr.Length - 1 - i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public bool IsPalindrome2(int x)
        {
            if (x == 0)
            {
                return true;
            }
            else if (x < 0)
            {
                return false;
            }

            var str = x.ToString();

            var arr = str.ToCharArray();
            Array.Reverse(arr);

            var rev = new string(arr);

            return str == rev;
        }
    }
}
