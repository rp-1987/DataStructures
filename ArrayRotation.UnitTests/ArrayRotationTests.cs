using ArrayPrograms.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms.UnitTests
{
    [TestClass]
    public class ArrayRotationTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Rotate_WhenInputArrayIsNull_ThrowArgumentNullException()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();

            //Act
            var output = arrayRotation.Rotate(null, 2);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Rotate_WhenInputNumberIsZero_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            var output = arrayRotation.Rotate(inputArray, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Rotate_WhenInputNumberIsGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            var output = arrayRotation.Rotate(inputArray, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Rotate_WhenInputNumberIsEqualToArrayLength_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            var output = arrayRotation.Rotate(inputArray, inputArray.Length);
        }

        [TestMethod]
        public void Rotate_WhenValidArrayAndNumberPassed_RotatesArray()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[5] { 1, 2, 3, 4, 5 };
            int[] expectedArray = new int[5] { 3, 4, 5, 1, 2 };

            //Act
            var output = arrayRotation.Rotate(inputArray, 2);

            //Assert
            Assert.IsTrue(expectedArray.IsArrayEqual(output));
        }

        [TestMethod]
        public void FindPairWithGivenSum_WhenArrayContainsValidSum_ReturnsTrue()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[6] { 11, 15, 6, 8, 9, 10 };

            //Act
            var output = arrayRotation.FindPairWithGivenSum(inputArray, 19);

            //Assert
            Assert.IsTrue(output);

        }

        [TestMethod]
        public void FindPairWithGivenSum_WhenArrayDoesNotContainSum_ReturnsFalse()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[6] { 11, 15, 6, 8, 9, 10 };

            //Act
            var output = arrayRotation.FindPairWithGivenSum(inputArray, 120);

            //Assert
            Assert.IsFalse(output);

        }

        [TestMethod]
        public void RearrangeOddWithPrecedingEvenIndex_InputArrayIsSorted_ReturnsInput()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[5] { 1, 2, 3, 4, 5 };

            //Act
            var output = arrayRotation.RearrangeOddWithPrecedingEvenIndex(inputArray);

            //Assert
            Assert.IsTrue(output.Equals(inputArray));
        }

        [TestMethod]
        public void RearrangeOddWithPrecedingEvenIndex_InputArrayIsUnsorted_ReturnsEvenIndexLessThanOddIndex()
        {
            //Arrange
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[5] { 5, 4, 3, 2, 1 };
            int[] expectedOutput = new int[5] { 4, 5, 2, 3, 1 };

            //Act
            var output = arrayRotation.RearrangeOddWithPrecedingEvenIndex(inputArray);

            //Assert
            Assert.IsTrue(output.IsArrayEqual(expectedOutput));
        }

    }
}
