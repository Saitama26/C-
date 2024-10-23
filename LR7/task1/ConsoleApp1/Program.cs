using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSumOfNumbers(Console.ReadLine()));
        }

        public static double FindSumOfNumbers(string input)
        {
            double sum = 0;
            MatchCollection matches = Regex.Matches(input, @"-?\d+(,\d+)?([eE][+-]?\d+)?"); 

            foreach (Match match in matches)
            {
                if (double.TryParse(match.Value, out double num))
                {
                    Console.WriteLine(num);
                    sum += num;
                }
            }

            return sum;
        }

    }
}
