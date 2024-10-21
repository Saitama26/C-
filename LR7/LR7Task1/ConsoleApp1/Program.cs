using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            double sum = 0;
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"-?\d+(?:\.\d+)?(?:[eE][+-]?\d+)?");

            foreach (Match match in matches)
            {
                if (double.TryParse(match.Value, out double num))
                {
                    sum += num;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
