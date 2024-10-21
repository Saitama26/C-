namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string poems = "тучки небесные вечные странники"; 
            char[] div = { ' ' }; //создаем массив разделителей

            string[] parts = poems.Split(div);
            Console.WriteLine("Результат разбиения строки на части: ");
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);

            }
        
            string whole = String.Join(" | ", parts.Reverse()); 
            Console.WriteLine("Результат сборки: ");
            Console.WriteLine(whole);

        }
    }
}
