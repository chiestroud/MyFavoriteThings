using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    class Movie
    {
        public string Name { get; set; }
        public bool Watched { get; set; }

        public void Watch()
        {
            Console.WriteLine($"Let's watch {Name} today!");
        }

        public void Experience()
        {
            Console.WriteLine($"The answer to if I watched {Name} is {Watched}");
        }
    }
}
