namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task3();
        }
       
        static void Task3()
        {
            Random rnd = new Random();

            Console.WriteLine("N=");
            int n = int.Parse(Console.ReadLine());

            int[,] arrOfnumbers = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    arrOfnumbers[i, j] = rnd.Next(0, 99);

            PrintArr(arrOfnumbers, n);
            (int FirstMaxNumber, int SecondMaxNumber) = GetTwoMaxNumbers(arrOfnumbers, n);

            Console.WriteLine($"Максимальные 2 числа: {FirstMaxNumber}, {SecondMaxNumber}");
            arrOfnumbers[0, 0] = FirstMaxNumber;
            arrOfnumbers[0, 1] = 0;
            PrintArr(arrOfnumbers, n);
        }

        static (int, int) GetTwoMaxNumbers(int[,] arr, int n)
        {

            int FirstMax = arr[0, 0];
            int SecondMax = arr[1, 0];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)

                    if (arr[i, j] > FirstMax)
                    {
                        SecondMax = FirstMax;
                        FirstMax = arr[i, j];

                    }


            return (FirstMax, SecondMax);
        }

        static void PrintArr(int[,] arr, int n)
        {
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{arr[i, j],3}");
                Console.WriteLine();
            }
        }

    }
}
