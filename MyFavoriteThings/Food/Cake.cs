using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Food
{
    class Cake : Eat
    {
        public Cake(string name, bool favorite)
        {
            Name = name;
            isFavorite = favorite;
        }
    }
}
