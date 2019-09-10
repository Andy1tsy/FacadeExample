using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaFacade
{
    enum Extra
    {
        glasses = 100,
        towels = 15,

    }
    class Accessories
    {
        public int GetAccessories(Extra extra, int quantity)
        {
            switch (extra)
            {
                case Extra.glasses:
                    return (int)Extra.glasses * quantity;
                case Extra.towels:
                    return (int)Extra.towels * quantity;
                default:
                    throw new ArgumentOutOfRangeException(nameof(extra), extra, null);
            }
        }
    }
}
