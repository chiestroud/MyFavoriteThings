using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Vehicles
{
    class Toyota : Car
    {
        public int GasMileage { get; set; }
        public Toyota(string name, int gasMileage)
        {
            GasMileage = gasMileage;
            Name = name;
        }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"Mileage per gallon for this Toyota is {GasMileage}");
        }
    }
}
