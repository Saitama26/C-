namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
            Task3();
        }

        static void Task1()
        {
            Console.WriteLine("Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name}, ты родился в {2024 - age} году.");
        }

        static void Task2()
        {
            Console.WriteLine($"Первый член прогрессии ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Разность прогрессии ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число членов прогрессии ");
            int n = int.Parse(Console.ReadLine());
            float Sum = (2 * a1 + d * (n - 1)) / 2 * n ;
            Console.WriteLine($"Сумма: {Sum}");
        }

        static void Task3()
        {
            Console.WriteLine("Введите трехзначное число ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 10 == num / 10 % 10 && num / 100 % 10 == num % 10) ? "Одинаковые" : "Неодинаковые");
        }

    }
}
