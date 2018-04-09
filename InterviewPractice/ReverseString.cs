using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public class ReverseString
    {
        public static string Reverse(string toReverse)
        {
            if (toReverse.Length <= 1) return toReverse;
            return Reverse(toReverse.Substring(1)) + toReverse[0];
        }

        public static string ReverseIterative(string toReverse)
        {
            var reversed = new StringBuilder();
            for (int i = toReverse.Length - 1; i >= 0; i--)
            {
                reversed.Append(toReverse[i]);
            }
            return reversed.ToString();
        }
    }
}
