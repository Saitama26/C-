namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        static void Task1()
        {
            for (int i = 100; i < 1000; i++)
            {

                int hundreds = i / 100;
                int tens = (i / 10) % 10;
                int ones = i % 10;

                if (hundreds == tens || hundreds == ones || tens == ones)
                    Console.WriteLine(i);
            }
        }

        static void Task2()
        {
            Console.Write("n= ");
            byte n = byte.Parse(Console.ReadLine());
            int num = 2;
            for (byte i = n; i >= 1; --i)
            {
                for (byte j = 1; j <= i; ++j)
                {
                    Console.Write("{0,4}", 2);
                }
                Console.WriteLine();
                for (byte j = 1; j <= i; ++j)
                {
                    Console.Write("{0,4}", num + j);
                }
                num--;
                Console.WriteLine();


            }

        }

        static void Task3()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h= ");
            double h = double.Parse(Console.ReadLine());
            double y;
            int i = 1;
            Console.WriteLine("{0,3} {1,5} {2,5}", "#", "x", "f(x)");
            for (double x = a; x <= b; x += h, ++i)
            {
                if (x+2 < 0)
                    y = Math.Pow(x, 2);
                else if (x+2 > 1 && x+2 < 10)
                    {y = 1/(x+2);}
                else
                    {y = x + 2;}
                Console.WriteLine("{0,3} {1,5:f2} {2,5:f2}", i, x, y);
            }
        }
    }
} 

       