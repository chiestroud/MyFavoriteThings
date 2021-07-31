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
            if (Watched)
            {
                Console.WriteLine($"I have watched {Name}");
            }
            else
            {
                Console.WriteLine($"I have never watched {Name}");
            }
            
        }
    }
}
