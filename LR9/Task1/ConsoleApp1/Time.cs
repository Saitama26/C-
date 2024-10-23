namespace ConsoleApp1
{
    class Time
    {
        //поля класса
        private DateTime date; 
        private readonly bool IsLeapYear;

        //конструкторы класса
        public Time() { this.date = new DateTime(2010, 01, 01); }
        public Time(DateTime date) {  this.date = date; }

        //свойства класса
        public DateTime DATE
        { 
            get => this.date; // возвращает значение
            set => this.date = value; //установка значения
        }

        public bool isLeapYear
        {
            get => DateTime.IsLeapYear(this.date.Year); 
        }

        //индексатор
        public DateTime this[int i]
        {
            get => this.date.AddDays(i);//возвращает число относительно заданной даты
        }

        //методы класса
        public void DataPrevDay() => Console.WriteLine($"Дата предыдущего дня: {this.date.AddDays(-1)}");// возвращает дату предыдущего дня
        public void DataNextDay() => Console.WriteLine($"Дата следующего дня: {this.date.AddDays(1)}");// возвращает дату следующего дня
        public void DaysEndOfTheMonth() => Console.WriteLine($"До конца месяца {DateTime.DaysInMonth(this.date.Year, this.date.Month) - this.date.Day} дней."); // кол-во дней до конца месяца

        // перегрузка операторов
        public static bool operator !(Time Date) => Date.DATE.Day == DateTime.DaysInMonth(Date.DATE.Year, Date.DATE.Month);// возвращает true, если последний день месяца, иначе - false
        public static bool operator true(Time Date) => Date.DATE == new DateTime(Date.DATE.Year, 1, 1);// возвращает true, елси начало года, иначе - false
        public static bool operator false(Time Date) => Date.DATE != new DateTime(Date.DATE.Year, 1, 1);
        public static bool operator &(Time DateA, Time DateB) => DateA.DATE == DateB.DATE && DateA.IsLeapYear == DateB.IsLeapYear; // возвращает true, елси поля экземляров равны

    }
}
