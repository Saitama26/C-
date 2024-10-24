namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Software[] softwares =
            {
                new ProprietarySoftware("VK", "Pavel Durov", 2999, new DateTime(2014, 11, 17), 567, new DateTime(2006, 10, 6)),
                new SharewareSoftware("PhotoShop", "Adobe", new DateTime(2010, 7, 25), 30, new DateTime(2008, 1 ,1)),
                new FreeSoftware("Linux", "Linus Torvalds", new DateTime(2004, 5, 6))
            };

            foreach (Software software in softwares) 
                software.Show();
            Console.WriteLine("\n\n");


            Array.Sort(softwares);

            Console.WriteLine("Отсортированный массив: ");
            foreach (Software software in softwares)
                software.Show();





        }
    }
}
