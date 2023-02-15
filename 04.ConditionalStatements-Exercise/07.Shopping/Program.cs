using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            double priceN = N * 250;
            double priceM = (priceN * 0.35) * M;
            double priceP = (priceN * 0.1) * P;
            double price = priceN+priceM+priceP;
            if (N > M)
            {
                price -= (price * 0.15);
            }

            if (price > budget)
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva more!");
            }
            else
            {
                Console.WriteLine($"You have {budget-price:f2} leva left!");
            }
        }
    }
}
