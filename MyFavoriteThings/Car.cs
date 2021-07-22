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
        public string Type { get; set; }
        public string Color { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Let's go to drive with my {Name}");
        }

        public void Favorite()
        {
            Console.WriteLine($"My favorite type of car is {Type} and favorite color is {Color}");
        }
    }
}
