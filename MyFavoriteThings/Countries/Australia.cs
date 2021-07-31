using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Countries
{
    class Australia : Country
    {
        public int NumberOfTimesVisited { get; set; }
        public Australia(string name, string location, int number)
        {
            Name = name;
            NumberOfTimesVisited = number;
            Location = location;
        }

        public override void Travel()
        {
            base.Travel();
            Console.WriteLine($"I have been to australia {NumberOfTimesVisited} times");
        }
    }
}
