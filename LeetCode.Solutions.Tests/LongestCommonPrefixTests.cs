using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions;
using System;

[TestClass]
public class LongestCommonPrefixTests
{
    [DataTestMethod]
    [DataRow(new string[] { "dog", "racecar", "car" }, "")]
    [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
    [DataRow(new string[] { "word" }, "word")]
    [DataRow(new string[] { }, "")]
    [DataRow(new string[] { "c", "c" }, "c")]
    [DataRow(new string[] { "aa", "ab" }, "a")]
    [DataRow(new string[] { "ca", "a"}, "")]
    public void LongestCommonPrefixTest(string [] input, string expected)
    {
        var solver = new LongestCommonPrefixProblem();

        var result = solver.LongestCommonPrefix(input);

        Assert.AreEqual(expected, result);
    }
}