using System.Text;

namespace InterviewPractice
{
    public class FizzBuzz
    {
        public static string FizzBuzzer()
        {
            var sb = new StringBuilder();
            for (var i = 1; i <= 100; i++)
            {
                var result =
                    i % 15 == 0 ? "FizzBuzz" :
                    i % 3 == 0 ? "Fizz" :
                    i % 5 == 0 ? "Buzz" :
                    i.ToString();
                sb.AppendLine(result);
            }
            return sb.ToString();
        }
    }
}
