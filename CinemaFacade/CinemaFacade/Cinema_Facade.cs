using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaFacade
{
    class Cinema_Facade
    {
        private readonly Tickets _tickets;
        private readonly Food _food;
        private readonly Accessories _accessories;
        public Cinema_Facade()
        {
            _tickets = new Tickets();
            _food = new Food();
            _accessories = new Accessories();
        }

        public int GetTicketsOnRegularMovie(MoviesTime time, int quantity, Foods food, Extra extra)
        {
            int tickettsPrice = _tickets.OrderTickets(time, quantity);
            int foodsPrice = _food.OrderFood(quantity, food);
            int accessoriesPrice = _accessories.GetAccessories(extra, quantity);
            return tickettsPrice + foodsPrice + accessoriesPrice;
        }

        public int GetTicketsOn3DMovie(MoviesTime time, int quantity, Extra extra, params Foods[] food)
        {
            int tickettsPrice = _tickets.OrderTickets(time, quantity);
            int foodsPrice = _food.OrderFood(quantity, food);
            int accessoriesPrice = _accessories.GetAccessories(extra, quantity);
            return tickettsPrice + foodsPrice + accessoriesPrice;
        }



    }
}
