using System;
using System.Diagnostics;

namespace _04.FishBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int br = int.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Spring":
                    price = evenDiscount(countDiscount(3000, br), br);
                    break;
                case "Summer":
                    price = evenDiscount(countDiscount(4200, br), br);
                    break;
                case "Autumn":
                    price = countDiscount(4200, br);
                    break;
                case "Winter":
                    price = evenDiscount(countDiscount(2600, br), br);
                    break;
            }
            if (price == 0) return;
            if (budget >= price)
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            else Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
        }

        static double countDiscount(double price, int br)
        {
            if (br <= 6)
                price -= price * 0.1;
            else if (br > 6 && br <= 11)
                price -= price * 0.15;
            else price -= price * 0.25;
            return price;
        }

        static double evenDiscount(double price, int br)
        {
            if (br % 2 == 0)
                return price - price * 0.05;
            return price;
        }
    }
}
