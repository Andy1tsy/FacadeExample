using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaFacade
{
    enum Foods
    {
        Cola = 15,
        Hamburger = 25,
        Hotdog = 20,
        Popcorn = 30
    }
    class Food
    {
        public int OrderFood(int quantity, params Foods[] orderedFoods)
        {
            int orderedFoodPrice = 0;
            foreach(var item in orderedFoods)
            {
                orderedFoodPrice += (int)item;
            }
            return orderedFoodPrice * quantity;
        }
    }
}
