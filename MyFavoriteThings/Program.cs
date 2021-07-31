using MyFavoriteThings.Countries;
using MyFavoriteThings.Food;
using MyFavoriteThings.Movies;
using MyFavoriteThings.Vehicles;
using System;
using System.Collections.Generic;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var foods = new List<Eat>() { new FrenchFries("French Fries", true), new Cake("Lemon Cake", false)};
            foreach (var deliciousness in foods)
            {
                deliciousness.Breakfast();
                deliciousness.Favorite();
            }
            // Before learning inheritance
            //var frenchFries = new Eat
            //{
            //    Name = "French Fries",
            //    Type = "junk"
            //};

            //frenchFries.Breakfast();
            //frenchFries.Favorite();

            //var potatoChips = new Eat
            //{
            //    Name = "Potato Chips",
            //    Type = "junk"
            //};

            //potatoChips.Breakfast();
            //frenchFries.Favorite();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            //var brz = new Car
            //{
            //    Name = "BRZ",
            //    Type = "coupe",
            //    Color = "blue"
            //};

            //brz.Drive();
            //brz.Favorite();


            // each vehicle inherit from class Car
            var cars = new List<Car>() {new Subaru("BRZ", "Rally Blue"), new Subaru("WRX", "White"), new Toyota("86", 34) };
            foreach (var car in cars)
            {
                car.Drive();
                car.Favorite();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            var movies = new List<Movie>() { new Horror("Hereditary", true), new ActionMovie("Men In Black", false) };
            foreach (var movie in movies)
            {
                movie.Watch();
                movie.Experience();
            }
            //var stuart = new Movie
            //{
            //    Name = "Stuart Little",
            //    Watched = true
            //};

            //stuart.Watch();
            //stuart.Experience();

            //var lotr = new Movie
            //{
            //    Name = "Lord of the Ring",
            //    Watched = true
            //};

            //lotr.Watch();
            //lotr.Experience();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            var countries = new List<Country>() { new Australia("Australia", "down under", 3), new Japan("Japan", "Asia")};
            foreach (var country in countries)
            {
                country.Travel();
                country.Map();
            }

            // Before learning inheritance
            //var australia = new Country
            //{
            //    Name = "Australia",
            //    Location = "Down Under"
            //};

            //australia.Travel();
            //australia.Map();

            //var japan = new Country
            //{
            //    Name = "Japan",
            //    Location = "East"
            //};

            //japan.Travel();
            //japan.Map();
            Console.ForegroundColor = ConsoleColor.White;
           
        }
    }
}
