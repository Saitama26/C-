namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            //Task2();

        }
        static void Task1() {
            Console.WriteLine("x1 = "); // ввод координат пользователем
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x3 = ");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("y3 = ");
            int y3 = int.Parse(Console.ReadLine());



            double d12 = F(x1, x2, y1, y2);// нахождение длины между точками
            double d13 = F(x1, x3, y1, y3);
            double d23 = F(x2, x3, y2, y3);

            //Console.WriteLine("{0}\t{1}\t{2}", d12, d13, d23);
            double minDistance = Min(Min(d12, d13), d23); // нахождение минимальной длины
            //Console.WriteLine(minDistance);

            //вывод точек с минамальной длиной
            if (minDistance == d12) { Console.WriteLine($"Минимальное расстояние: {minDistance},  между точками 1 и 2"); }
            else if (minDistance == d13) { Console.WriteLine($"Минимальное расстояние: {minDistance}, между точками 1 и 3"); }
            else { Console.WriteLine($"Минимальное расстояние: {minDistance}, между точками 2 и 3"); }
        }

        static void Task2()
        {
            Console.WriteLine("N="); 
            int N = int.Parse(Console.ReadLine());// ввод числа пользователем

            int Countdigit2 = 0; //переменная подсчета 2-разрядных чисел
            int Countdigit3 = 0; //переменная подсчета 3-разрядных чисел

            for (int i = 0; i < N; i++) {  // цикл, проходящий последовательность от 0 до N

                switch (isDigit(i)) //проверка числа на разрядность
                {
                    case 1: // 2-разрядное число
                        Countdigit2++;
                        break;
                    case 2:// 3-разрядное число
                        Countdigit3++;
                        break;
                }
            }

            //Вывод на экран
            Console.WriteLine($"Количество двухразрядных: {Countdigit2}\nКоличество трехразрядных: {Countdigit3}");


        }

        static double F(int x1, int y1, int x2, int y2) => Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        // функция возвращает длину между точками

        static double Min(double a, double b) => a > b ? b : a;
        //функция возвращает минимальное значение

        //функция, возвращает 1, если число 2-разрядное, 2, если 3-разрядное, иначе 0
        static byte isDigit(int number) {

            if (number >= 10 && number < 100) return 1;
            else if (number >= 100 && number < 1000) return 2;
            else return 0;
        
        }


    }
}
