using System;
using System.Runtime.CompilerServices;

namespace _05.Journey
{
    internal class Program
    {
        public static string place;
        public static double price;

        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season.Equals("summer"))
                {
                    place = "Camp";
                    price = budget * 0.3;
                }
                
                else if (season.Equals("winter"))
                {
                    place = "Hotel";
                    price = budget * 0.7;
                }
                    
                else Environment.Exit(0);
            }

            else if (budget>100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season.Equals("summer"))
                {
                    place = "Camp";
                    price = budget * 0.4;
                }

                else if (season.Equals("winter"))
                {
                    place = "Hotel";
                    price = budget * 0.8;
                }

                else Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Somewhere in Europe");
                place = "Hotel";
                price = budget * 0.9;
            }
            Console.WriteLine($"{place} - {price:f2}");
        }
    }
}
