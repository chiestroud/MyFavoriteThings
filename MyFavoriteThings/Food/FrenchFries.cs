using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Food
{
    class FrenchFries : Eat
    {
        public FrenchFries(string name, bool favorite)
        {
            Name = name;
            isFavorite = favorite;
        }

        public override void Favorite()
        {
            base.Favorite();
            Console.WriteLine($"{Name} is the best food I have ever had.");
        }

    }
}
