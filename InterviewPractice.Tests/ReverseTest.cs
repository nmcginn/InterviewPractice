using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewPractice.Tests
{
    public class ReverseTest
    {
        [Fact]
        public void TestReverse()
        {
            var testString = "Hello, World!";
            var reverse = ReverseString.Reverse(testString);
            Assert.Equal("!dlroW ,olleH", reverse);
        }

        [Fact]
        public void TestReverseIter()
        {
            var testString = "Hello, World!";
            var reverse = ReverseString.ReverseIterative(testString);
            Assert.Equal("!dlroW ,olleH", reverse);
        }
    }
}
