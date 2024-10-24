using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SharewareSoftware : Software
    {
        private string Name;
        private string Maker;
        private DateTime InstallationDate;
        private int PeriodOfFreeUse;
        private DateTime ReleaseDate;
        private bool Supported;

        protected override string GetName() => this.Name;

        public SharewareSoftware(string Name, string Maker, DateTime InstallationDate, int PeriodOfFreeUse)
        {
            this.Name = Name;
            this.Maker = Maker;
            this.InstallationDate = InstallationDate;
            this.PeriodOfFreeUse = PeriodOfFreeUse;
            this.ReleaseDate = DateTime.Now;
        }

        public SharewareSoftware(string Name, string Maker, DateTime InstallationDate, int PeriodOfFreeUse, DateTime ReleaseDate)
        {
            this.Name = Name;
            this.Maker = Maker;
            this.InstallationDate = InstallationDate;
            this.PeriodOfFreeUse = PeriodOfFreeUse;
            this.ReleaseDate = ReleaseDate;
        }

        public override void Show()
        {
            Console.WriteLine($"Название: {this.Name, 10}\t" +
                $"Производитель: {this.Maker, 10}\t" +
                $"Дата установки: {this.InstallationDate, 10}\n" +
                $"Пробный период: {this.PeriodOfFreeUse, 10}\t" +
                $"Дата выпуска: {this.ReleaseDate, 10}\n");
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
