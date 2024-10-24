namespace ConsoleApp1
{
    class ProprietarySoftware : Software
    {
        private string Name;
        private string Maker;
        private int Price;
        private DateTime InstallationDate;
        private int PeriodOfUse;
        private DateTime ReleaseDate;

        protected override string GetName() => this.Name;

        public ProprietarySoftware(string Name, string Maker, int Price, DateTime InstallationDate, int PeriodOfUse)
        {
            this.Name = Name;
            this.Maker = Maker;
            this.Price = Price;
            this.InstallationDate = InstallationDate;
            this.PeriodOfUse = PeriodOfUse;
            this.ReleaseDate = DateTime.Now;
        }

        public ProprietarySoftware(string Name, string Maker, int Price, DateTime InstallationDate, int PeriodOfUse, DateTime ReleaseDate)
        {
            this.Name = Name;
            this.Maker = Maker;
            this.Price = Price;
            this.InstallationDate = InstallationDate;
            this.PeriodOfUse = PeriodOfUse;
            this.ReleaseDate = ReleaseDate;
        }

        public override void Show()
        {
            Console.WriteLine($"Название: {this.Name,10}\t" +
                $"Производитель: {this.Maker,10}\t" +
                $"Цена: {this.Price,6}\n" +
                $"Дата установки: {this.InstallationDate,10}\t" +
                $"Период использования: {this.PeriodOfUse,10}\t" +
                $"Дата выпуска: {this.ReleaseDate}\n");
        }

        public override int PossibillityOfUsing()
        {
            if (this.ReleaseDate > ValidDate)
                return 1;
            else if (this.ReleaseDate == ValidDate)
                return 0;
            else
                return -1;
        }

    }
}
