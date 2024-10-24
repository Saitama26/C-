
namespace ConsoleApp1
{
    internal class FreeSoftware: Software
    {
        private string Name;
        private string Maker;
        private DateTime ReleaseDate;

        protected override string GetName() => this.Name;
        public FreeSoftware(string name, string maker)
        {
            this.ReleaseDate = DateTime.Now;
            this.Name = name;
            this.Maker = maker;
        }

        public FreeSoftware(string name, string maker, DateTime dateOfCreation)
        {
            this.ReleaseDate = dateOfCreation;
            this.Name = name;
            this.Maker = maker;
        }

        public override void Show()
        {
            Console.WriteLine($"Название: {this.Name, 10}\tПроизводитель: {this.Maker, 10}\n");
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
