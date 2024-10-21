namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }

        static int FindMinLength(int[] numbers)
        {
            int minLength = int.MaxValue;
            int currentLength = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > 0)
                    {
                        minLength = Math.Min(minLength, currentLength);
                        currentLength = 0;
                    }
                }
            }

            // Проверяем последнюю серию нечетных элементов
            if (currentLength > 0)
            {
                minLength = Math.Min(minLength, currentLength);
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }

        static void Task2()
        {
            Random rnd = new Random();

            int[] numbers = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 20);
            }

            PrintArr(numbers);

            Console.WriteLine($"Минимальная длина серии нечетных элементов: {FindMinLength(numbers)}");

            int countDel = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsPrime(numbers[i]))
                {
                    DelElemFromArraybyIndex(ref numbers, i);
                    countDel++;
                }

                if (countDel == 2) break;

            }

            PrintArr(numbers);
            Console.WriteLine($"Минимальная длина серии нечетных элементов: {FindMinLength(numbers)}");

        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write($"{arr[i],3}");
            }
            Console.WriteLine();
        }

        static void DelElemFromArraybyIndex(ref int[] arr, int index)
        {
            int[] array = new int[arr.Length - 1];

            for(int i = 0 ; i < index ; ++i)
            {
                array[i] = arr[i];
            }
            for(int i = index; i < arr.Length - 1; ++i)
            {
                array[i] = arr[i+1];
            }

            arr = array;
        }


    }
}
