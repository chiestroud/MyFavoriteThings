using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    class Country
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual void Travel()
        {
            Console.WriteLine($"I am going to {Name}");
        }

        public void Map()
        {
            Console.WriteLine($"{Name} is located in {Location}");
        }



    }
}
