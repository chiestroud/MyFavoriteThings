using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Countries
{
    class Japan : Country
    {
        public Japan(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public override void Travel()
        {
            base.Travel();
            Console.WriteLine($"I was born in {Name}");
        }
    }
}
