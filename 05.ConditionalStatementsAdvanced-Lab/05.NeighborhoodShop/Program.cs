using System;

namespace _05.NeighborhoodShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double br = double.Parse(Console.ReadLine());
            double price = 0;
            if (city.Equals("Sofia"))
            {
                switch (product)
                {
                    case "coffee":
                        price=0.5 * br;
                        break;
                    case "water":
                        price = 0.8 * br;
                        break;
                    case "beer":
                        price = 1.2 * br;
                        break;
                    case "sweets":
                        price = 1.45 * br;
                        break;
                    case "peanuts":
                        price = 1.6 * br;
                        break;
                }
            }else if (city.Equals("Plovdiv"))
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.4 * br;
                        break;
                    case "water":
                        price = 0.7 * br;
                        break;
                    case "beer":
                        price = 1.15 * br;
                        break;
                    case "sweets":
                        price = 1.30 * br;
                        break;
                    case "peanuts":
                        price = 1.5 * br;
                        break;
                }
            }
            else if(city.Equals("Varna"))
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.45 * br;
                        break;
                    case "water":
                        price = 0.7 * br;
                        break;
                    case "beer":
                        price = 1.1 * br;
                        break;
                    case "sweets":
                        price = 1.35 * br;
                        break;
                    case "peanuts":
                        price = 1.55 * br;
                        break;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
