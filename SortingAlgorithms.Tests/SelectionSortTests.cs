using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;
using SortingAlgorithms.Tests.Utilities;

namespace SortingAlgorithms.Tests
{
    [TestClass]
    public class SelectionSortTests
    {
        [TestMethod]
        public void SelectionSort_WhenUnsortedArrayPassed_ReturnsSortedArray()
        {
            //Arrange
            var sortingAlgorithm = new ShellSort();
            var inputArray = new int[5] { 12, 11, 10, 9, 8 };
            var expectedOutput = new int[5] { 8, 9, 10, 11, 12 };

            //Act
            var actualOutput = sortingAlgorithm.SortArray(inputArray);

            //Assert
            Assert.IsTrue(expectedOutput.IsArrayEqual(actualOutput));
        }


    }
}
