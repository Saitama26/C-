namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            Random rnd = new Random();

            Console.WriteLine("N= ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 11);
            }

            PrintArr(arr);
            Console.WriteLine($"Кол-во пар: {GetNumberOfPairs(arr)}");
        }


        static int GetNumberOfPairs(int[] arr) {

            int count = 0;

            for (int i = 1; i < arr.Length; i++) {

                if ((arr[i] + arr[i - 1]) % 2 == 0)
                    count++;
            
            }

            return count;
        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write($"{arr[i], 3}");
            }
            Console.WriteLine();
        } 


    }

}
