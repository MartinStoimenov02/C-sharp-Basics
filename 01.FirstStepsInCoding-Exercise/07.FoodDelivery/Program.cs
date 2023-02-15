using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());
            double menu = chicken * 10.35 + fish * 12.40 + vegan * 8.15;
            double finalPrice = menu + menu * 0.2 + 2.5;
            Console.WriteLine(finalPrice);
        }
    }
}