﻿using System;
using System.Text;
using Xunit;

namespace InterviewPractice.Tests
{
    public class StackTest
    {
        [Fact]
        public void TestStack()
        {
            // arrange
            var stack = new Stack<string>();
            // act
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            var c = stack.Pop();
            var b = stack.Pop();
            var a = stack.Pop();
            // assert
            Assert.True(stack.IsEmpty());
            Assert.Equal("A", a);
            Assert.Equal("B", b);
            Assert.Equal("C", c);
        }
    }
}
