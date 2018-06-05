using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerKing
{
    class ReservationsSystem
    {
        LinkedList<Reservations> Rezervacii;
        public ReservationsSystem()
        {
            Rezervacii = new LinkedList<Reservations>();
        }
        public void addReservation(Reservations reservations)
        {
            if(!(reservations.Date>DateTime.Now))
            Rezervacii.AddLast(reservations);

        }
        public void RefreshReservations()
        {
            foreach(Reservations res in Rezervacii)
            {
                Rezervacii.Remove(res);
            }
        }
        public void chechIfPassed()
        {
            foreach(Reservations res in Rezervacii)
            {
                if (res.Date > DateTime.Now)
                    Rezervacii.Remove(res);
            }
        }
       
    }
}
