namespace ConsoleApp1
{

    struct Information
    {
        public string Carrier;
        public int Volume;
        public string Name;
        public string Author;

        public void Print()
        {
            Console.WriteLine($"Carrier: {Carrier, 15}\t" +
                $"Volume: {Volume,7}\t" +
                $"Name: {Name,15}\t" +
                $"Author: {Author,15}\n");
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] carriers = { "DVD", "CD-ROM", "USB-флешка", "Винчестер", "Магнитная лента", "Оптический диск", "Карта памяти" };
            int[] volumes = { 4, 700, 32, 500, 10000, 16, 128 };
            string[] names = { "Война и мир", "Гарри Поттер", "Мастер и Маргарита", "Дон Кихот", "Преступление и наказание", "Властелин колец", "Анна Каренина" };
            string[] authors = { "Лев Толстой", "Джоан Роулинг", "Михаил Булгаков", "Мигель де Сервантес", "Фёдор Достоевский", "Джон Толкин", "Лев Толстой" };

            Information[] information = new Information[carriers.Length];

            for (int i = 0; i < carriers.Length; i++)
            {
                information[i] = new Information { Carrier = carriers[i], Volume = volumes[i], Name = names[i], Author = authors[i] };
            }

            Console.WriteLine("Вывод массива: ");
            foreach (Information info in information) 
                info.Print();
            

            Console.WriteLine("Введите объем: ");
            int volume = int.Parse(Console.ReadLine());
            DeleteElemWithMinVolume(ref information, volume);

            Console.WriteLine("Массив после удаления элемента");
            foreach (Information info in information)
                info.Print();

            
            Console.WriteLine("Введите K= ");
            byte k = byte.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                Append(ref information, new Information {Carrier=Console.ReadLine(),  Volume = int.Parse(Console.ReadLine()), Name= Console.ReadLine(), Author = Console.ReadLine()});
            }

            Console.WriteLine($"Массив после добавления {k} элементов");
            foreach (Information info in information)
                info.Print();
        }

        static void DeleteElemWithMinVolume(ref Information[] information, int Volume) {
            Information[] timeArray = new Information[information.Length - 1];

            int index = 0;

            for (int i = 0; i < information.Length; i++) {

                if (information[i].Volume == Volume)
                {
                    index = i; break;
                }

            }

            for (int i = 0; i < index; i++) 
                timeArray[i] = information[i];
            
            for (int i = index; i < information.Length - 1; i++)
                timeArray[i] = information[i + 1];

            information = timeArray;

        }

        static void Append(ref Information[] array, Information info)
        {
            Information[] newArr = new Information[array.Length + 1];

            for( int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }

            newArr[newArr.Length - 1] = info;
            array = newArr;
        }

        
    }
}
