namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();// создание экземляра класса
            Time time2 = new Time(DateTime.Now); // создание экземляра класса

            Console.WriteLine(time.DATE.ToString()); // вывод даты
            Console.WriteLine(time2.DATE.ToString()); // вывод даты

            // обращение к свойству экземляра класса
            if (time.isLeapYear) Console.WriteLine("Високосный"); 
            else Console.WriteLine("Не високосный");

            if (time2.isLeapYear) Console.WriteLine("Високосный");
            else Console.WriteLine("Не високосный");

            // вызов методов экземляра класса
            time.DataPrevDay();
            time.DataNextDay();
            time.DaysEndOfTheMonth();

            // обращение по индексам
            for (int i = -5; i < 6; i++)
                Console.WriteLine(time2[i]);

            // использование перегруженных операторов
            if (!time2) Console.WriteLine("Последний день месяца");
            else Console.WriteLine("Не последний день месяца");

            if (time) Console.WriteLine("Начало года");
            else Console.WriteLine("Не начало года");

            if(time & time2) Console.WriteLine("Равны");
            else Console.WriteLine("Не равны");
        }
    }
}
