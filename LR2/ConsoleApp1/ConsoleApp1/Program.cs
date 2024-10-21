namespace ConsoleApp1
{
    class Program
    {
        const int R = 1;


        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        static void Task1()
        {
            Console.WriteLine("Введите x: ");
            int x = int.Parse(Console.ReadLine());

            if (x == 2)
            {
                Console.WriteLine("Неккоректное значение");
            }
            else
            {

                double y = Math.Log(Math.Abs(x - 2), Math.E);

                Console.WriteLine(y);
            }
        }

        static void Task2()
        {

            Console.WriteLine("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y= ");
            double y = double.Parse(Console.ReadLine());


            if ((x * x + y * y < R * R) ||
                (x > 0 && x < 5) && (y > 0 && y < (x - 5) / -5) ||
                (x < 0 && x > -5) && (y < 0 && y > (-x - 5) / 5))
            { Console.WriteLine("Внутри"); }
            else if (
                x > 5 || x < -5 ||
                (x > 0 && (y < 0 || y > (x - 5) / -5)) ||
                (x < 0 && (y > 0 || y < (-x - 5) / 5) ) || 
                (x * x + y * y < R * R)
                )
            {Console.WriteLine("Снаружи");}
            else { Console.WriteLine("На границе"); }
        }

        static void Task3()
        {
            Console.WriteLine("Введите признак: ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case ("а"):
                    Console.WriteLine("Максимальная скорость автомобиля - 300 км/ч");
                    break;

                case ("в"):
                    Console.WriteLine("Максимальная скорость велосипеда - 50 км/ч");
                    break;

                case ("м"):
                    Console.WriteLine("Максимальная скорость мотоцикла - 250 км/ч");
                    break;
                 
                case ("с"):
                    Console.WriteLine("Максимальная скорость самолёта - 1000 км/ч");
                    break;

                case ("п"):
                    Console.WriteLine("Максимальная скорость поезда - 320 км/ч");
                    break;
            }

        }
    }
}
