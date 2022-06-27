using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckpointJaakko
{
    class Program
    {
        static void Main(string[] args)
        {
            City city1 = new City("Rome", 2873000);
            City city2 = new City("Paris", 2161000);
            City city3 = new City("London", 8982000);
            City city4 = new City("Nairobi", 4397000);
            City city5 = new City("Los Angeles", 3973000);
            City city6 = new City("New Delhi", 257804);
            City city7 = new City("Amsterdam", 821752);
            City city8 = new City("Abu Dhabi", 1450000);
            City city9 = new City("Zurich", 402762);

            List<City> cities = new List<City> { city1, city2, city3, city4, city5, city6, city7, city8, city9 };

            string firstLetter = AskFirstLetter();
            string lastLetter = AskLastLetter();
            Console.Clear();

            var foundCities = new List<string>();

            foreach (var city in cities)
            {
                if (city.Name.StartsWith(firstLetter) && city.Name.EndsWith(lastLetter))
                {
                    foundCities.Add("City:" + city.Name + ", Population:" + city.Population);
                }
            }

            Console.WriteLine("Found cities with input letters are:");
            Console.WriteLine();

            foreach (var foundcity in foundCities)
            {
                Console.WriteLine(foundcity);
            }

            Console.WriteLine();
            Console.WriteLine();

            var cityMax = cities.Min(city => city.Population);


            var maxSearch = cities.Find(city2 => city2.Population == cityMax);

            Console.WriteLine("City with lowest population is {0} ", maxSearch);

        }

        // asking user first letter with some robust mechanics

        public static string AskFirstLetter()
        {
            Console.WriteLine("Enter first letter");

            Console.WriteLine("write only one character!!!");
            Console.WriteLine("dont write more than one character!!");
            string firstLetter = Console.ReadLine();
            Console.WriteLine("if you write more than one character this doesnt work!!!!!");
            Console.WriteLine("Come on you must try harder!!!");
            return firstLetter.ToUpper();
        }

        // asking user last letter with some robust mechanics


        public static string AskLastLetter()
        {
            Console.WriteLine("Enter last letter");
            string lastLetter = Console.ReadLine();
            return lastLetter.ToLower();
        }


        class City
        {
            public string Name { get; set; }
            public int Population { get; set; }


            public City(string name, int population)
            {
                this.Name = name;
                this.Population = population;
            }

            public override string ToString()
            {
                return string.Format("{0} " +
                                     "{1}\n", Name, Population);
            }
        }
    }
}