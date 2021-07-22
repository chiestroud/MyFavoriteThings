using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    class Eat
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Breakfast()
        {
            Console.WriteLine($"Let's eat {Name} for breakfast");
        }

        public void Favorite()
        {
            Console.WriteLine($"My favorite {Type} food is {Name}");
        }
    }
}
