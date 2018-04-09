using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewPractice.Tests
{
    public class BreadthAndDepthTest
    {
        [Fact]
        public void TestDepth()
        {
            // Arrange
            var testData = Node.GetTestData();
            // Act
            var result = BreadthAndDepth.DepthFirstSearch(testData);
            // Assert
            Assert.Equal("ADGFCEB", result);
        }

        [Fact]
        public void TestBreadth()
        {
            // Arrange
            var testData = Node.GetTestData();
            // Act
            var result = BreadthAndDepth.BreadthFirstSearch(testData);
            // Assert
            Assert.Equal("ABCDEFG", result);
        }
    }
}
