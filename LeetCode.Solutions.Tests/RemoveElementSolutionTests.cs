﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Tests
{
    [TestClass]
    public class RemoveElementSolutionTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2, -1, -1 })]
        [DataRow(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 4, 0, 3, -1, -1, -1 })] 
        [DataRow(new int[] { 1 }, 1, 0, new int[] { -1 })]
        public void RemoveElementTest(int[] sourceArray, int valueToRemove, int expectedResult, int[] resultArray)
        {
            var solver = new RemoveElementSolution();

            var result = solver.RemoveElement(sourceArray, valueToRemove);

            Assert.AreEqual(expectedResult, result);
            CollectionAssert.AreEquivalent(resultArray, sourceArray);
        }
    }
}