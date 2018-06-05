using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerKing
{
    class Reservations
    {
        public string Name { set; get; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public DateTime Date { set; get; }
        Reservations()
        {
            Date = new DateTime();
        }

        public override string ToString()
        {
            return string.Format("Name:{0} Last Name {1} Age{2} has a reservations for {3}", Name
                , LastName, Age, Date);
        }
    }
}
