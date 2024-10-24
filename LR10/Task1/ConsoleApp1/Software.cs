using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Software : IComparable
    {
        protected static readonly DateTime ValidDate= new DateTime(2005, 1, 1);
        public abstract void Show();
        public abstract int PossibillityOfUsing();
        protected abstract string GetName();
        public int CompareTo(object? obj)
        {
            Software software = (Software) obj;

            if (software != null)
            {
                return this.GetName().CompareTo(software.GetName());
            }
            else throw new ArgumentException("Object is not a Software");
        }


    }
}
