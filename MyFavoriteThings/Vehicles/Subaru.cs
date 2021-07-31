using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Vehicles
{
    class Subaru : Car
    {
        public Subaru(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public void CrazyDrive()
        {
            Console.WriteLine($"I have Subaru {Name} and the color is {Color}");
        }

        public override void Drive()
        {
            CrazyDrive();
        }

        public override void Favorite()
        {
            base.Favorite();
            Console.WriteLine("I LOVE THIS CAR!!!!!!!!");
        }
    }
}
