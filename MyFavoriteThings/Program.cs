using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var frenchFries = new Eat
            {
                Name = "French Fries",
                Type = "junk"
            };

            frenchFries.Breakfast();
            frenchFries.Favorite();

            var potatoChips = new Eat
            {
                Name = "Potato Chips",
                Type = "junk"
            };

            potatoChips.Breakfast();
            frenchFries.Favorite();

            Console.WriteLine();

            var brz = new Car
            {
                Name = "BRZ",
                Type = "coupe",
                Color = "blue"
            };

            brz.Drive();
            brz.Favorite();

            var wrx = new Car
            {
                Name = "WRX",
                Type = "sedan",
                Color = "blue"
            };

            wrx.Drive();
            wrx.Favorite();

            Console.WriteLine();

            var stuart = new Movie
            {
                Name = "Stuart Little",
                Watched = true
            };

            stuart.Watch();
            stuart.Experience();

            var lotr = new Movie
            {
                Name = "Lord of the Ring",
                Watched = true
            };

            lotr.Watch();
            lotr.Experience();

            Console.WriteLine();

            var australia = new Country
            {
                Name = "Australia",
                Location = "Down Under"
            };

            australia.Travel();
            australia.Map();

            var japan = new Country
            {
                Name = "Japan",
                Location = "East"
            };

            japan.Travel();
            japan.Map();
           
        }
    }
}
