using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade_regular = new Cinema_Facade();
            var price_regular = facade_regular.GetTicketsOnRegularMovie(MoviesTime.at12, 2, Foods.Popcorn, Extra.towels);
            Console.WriteLine("price for daytime regular movie for 2 person : " + price_regular +" UAH.");

            var facade_3D = new Cinema_Facade();
            var price_3D = facade_3D.GetTicketsOn3DMovie(MoviesTime.at21, 2, Extra.glasses, Foods.Popcorn, Foods.Cola);
            Console.WriteLine("price for evening 3D movie for 2 person : " + price_3D + " UAH.");

            Console.ReadKey(true);
        }
    }
}
