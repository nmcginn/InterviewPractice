using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewPractice.Tests
{
    public class SortTest
    {
        [Fact]
        public void TestSort()
        {
            // Arrange
            var testData = new int[] { 3, 6, 1, 4, 11 };
            // Act
            testData = Sort<int>.SortArray(testData);
            // Assert
            Assert.Equal(1, testData[0]);
            Assert.Equal(3, testData[1]);
            Assert.Equal(4, testData[2]);
            Assert.Equal(6, testData[3]);
            Assert.Equal(11, testData[4]);
        }

        [Fact]
        public void TestMergeSort()
        {
            // Arrange
            var testData = new int[] { 3, 6, 1, 4, 11 };
            // Act
            testData = Sort<int>.MergeSort(testData, 0, testData.Length - 1);
            // Assert
            Assert.Equal(1, testData[0]);
            Assert.Equal(3, testData[1]);
            Assert.Equal(4, testData[2]);
            Assert.Equal(6, testData[3]);
            Assert.Equal(11, testData[4]);
        }
    }
}
