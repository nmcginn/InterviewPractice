using System;
using Xunit;
using binary_search;

namespace InterviewPractice.Tests
{
    public class BinarySearchTest
    {
        [Fact]
        public void TestFive()
        {
            // arrange
            var numbers = new int[]{ 1, 3, 5, 7, 9 };
            // act
            var three = BinarySearch.FindNumber(numbers, 4);
            var one = BinarySearch.FindNumber(numbers, 1);
            var nine = BinarySearch.FindNumber(numbers, 9);
            var five = BinarySearch.FindNumber(numbers, 5);
            // assert
            Assert.Equal(five, 5);
            Assert.Equal(one, 1);
            Assert.Equal(three, 3);
            Assert.Equal(nine, 9);
        }

        [Fact]
        public void TestFour()
        {
            // arrange
            var numbers = new int[]{ 3, 5, 7, 9};
            // act
            var three = BinarySearch.FindNumber(numbers, 4);
            var five = BinarySearch.FindNumber(numbers, 6);
            var nine = BinarySearch.FindNumber(numbers, 9);
            // assert
            Assert.Equal(five, 5);
            Assert.Equal(nine, 9);
            Assert.Equal(three, 3);
        }
    }
}
