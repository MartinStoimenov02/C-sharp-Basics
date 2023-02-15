using System;

namespace _05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int ActorsBr = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            double clothingTotal = ActorsBr * clothingPrice;
            if (ActorsBr > 150)
            {
                clothingTotal -= clothingTotal * 0.1;
            }
            double priceTotal = decor + clothingTotal;
            if (priceTotal <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-priceTotal:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {priceTotal-budget:f2} leva more.");
            }
        }
    }
}
