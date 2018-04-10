using System;
using Xunit;

namespace InterviewPractice.Tests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void TestFizzBuzz()
        {
            // arrange
            // act
            var result = FizzBuzz.FizzBuzzer();
            var results = result.TrimEnd().Split(Environment.NewLine);
            // assert
            Assert.Equal(100, results.Length);
            Assert.Equal("1", results[0]);
            Assert.Equal("Fizz", results[2]);
            Assert.Equal("Buzz", results[4]);
            Assert.Equal("FizzBuzz", results[14]);
        }
    }
}
