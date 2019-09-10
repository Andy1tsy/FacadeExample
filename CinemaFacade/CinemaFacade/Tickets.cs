using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaFacade
{
    enum  MoviesTime
    {
        at12 = 12,
        at15 = 15,
        at18 = 18,
        at21 = 21
    }

    enum TicketPrice
    {
        Day = 60,
        Evening = 80
    }

    class Tickets
    {
        public int OrderTickets(MoviesTime time, int quantity)
        {
            switch (time)
            {
                case MoviesTime.at12:
                case MoviesTime.at15:
                    return (int)TicketPrice.Day * quantity;
                case MoviesTime.at18:
                case MoviesTime.at21:
                    return (int)TicketPrice.Evening * quantity;
                default:
                    throw new ArgumentOutOfRangeException(nameof(time), time, null);
            }
        }
    }
}
