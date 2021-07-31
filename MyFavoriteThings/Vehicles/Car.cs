using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; } = "Orange";

        public virtual void Drive()
        {
            Console.WriteLine($"Let's go to drive with my {Name}");
        }

        public virtual void Favorite()
        {
            Console.WriteLine($"My favorite type of car is {Name} and favorite color is {Color}");
        }
    }
}
