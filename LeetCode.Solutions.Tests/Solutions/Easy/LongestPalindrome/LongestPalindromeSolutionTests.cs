﻿using LeetCode.Solutions.Solutions.Easy.LongestPalindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Solutions.Easy.LongestPalindrome
{
    [TestClass()]
    public class LongestPalindromeSolutionTests
    {
        [DataTestMethod()]
        [DataRow("abccccdd", 7)]
        [DataRow("aaabbbccccdd", 11)]
        [DataRow("a", 1)]
        [DataRow("bb", 2)]
        [DataRow("ccc", 3)]
        [DataRow("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth", 983)]
        public void LongestPalindromeTest(string s, int expected)
        {
            var actual = new LongestPalindromeSolution().LongestPalindrome(s);

            Assert.AreEqual(expected, actual);
        }
    }
}