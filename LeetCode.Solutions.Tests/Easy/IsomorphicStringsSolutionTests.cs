﻿using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Solutions.Tests.Easy
{
    [TestClass()]
    public class IsomorphicStringsSolutionTests
    {
        [DataTestMethod()]
        [DataRow("egg", "add", true)]
        [DataRow("foo", "bar", false)]
        [DataRow("paper", "title", true)]
        [DataRow("badc", "baba", false)]
        public void IsIsomorphicTest(string s, string t, bool expected)
        {
            var result = new IsomorphicStringsSolution().IsIsomorphic(s, t);

            Assert.AreEqual(expected, result);
        }
    }
}