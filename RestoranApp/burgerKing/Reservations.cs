using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerKing
{
   public class Reservations
    {
        public Reservations(string name, bool smokers, int tableFor, DateTime date)
        {
            Name = name;
            Smokers = smokers;
            TableFor = tableFor;
            Date = date;
        }

        public string Name { set; get; }
        public bool Smokers { get; set; }

        public int TableFor { get; set; }
        public DateTime Date { set; get; }
      

        public override string ToString()
        {
            return string.Format("Name:{0} Time: {1} Table for {2} ", Name
                , Date, TableFor);
        }
    }
}
