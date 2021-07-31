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
        public bool isFavorite { get; set; }

        public virtual void Breakfast()
        {
            Console.WriteLine($"Let's eat {Name} for breakfast");
        }

        public virtual void Favorite()
        {
            if (isFavorite)
            {
                Console.WriteLine($"{Name} is my favorite food");
            }
            else
            {
                Console.WriteLine($"{Name} is not my favorite food");
            }
            
        }
    }
}
