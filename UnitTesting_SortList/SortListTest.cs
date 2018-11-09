using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IComparer_Bubble_Sort;
using System.Collections.Generic;

namespace UnitTesting_SortList
{
    [TestClass]
    public class SortListTest
    {
        [TestMethod]
        public void SortList_Test_Int()
        {
            // Arrange
            SortList sortList = new SortList();
            List<int> expected;
            List<int> actual;

            // Act
            sortList.intList = new List<int>() {5, 2, 3, 1, 4 };
            expected = new List<int>() {1, 2, 3, 4, 5 };

            //This sort uses intList to sort for this test project!
            actual = sortList.Sort();

            // Assert
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);
            Assert.AreEqual(expected[4], actual[4]);
        }
    }
}
