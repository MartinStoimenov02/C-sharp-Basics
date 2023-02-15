using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTour = double.Parse(Console.ReadLine());
            int puzzleBr = int.Parse(Console.ReadLine());
            int dollsBr = int.Parse(Console.ReadLine());
            int tedyBearBr = int.Parse(Console.ReadLine());
            int minjorBr = int.Parse(Console.ReadLine());
            int truckBr = int.Parse(Console.ReadLine());
            double price = puzzleBr * 2.6 + dollsBr * 3 + tedyBearBr * 4.10
                + minjorBr * 8.2 + truckBr * 2;
            int br = puzzleBr + dollsBr + tedyBearBr + minjorBr + truckBr;
            if (br >= 50)
            {
                price -= price * 0.25;
            }
            price -= price * 0.1;
            if (price >= priceTour)
            {
                Console.WriteLine($"Yes! {price-priceTour:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceTour - price:f2} lv needed.");
            }
        }
    }
}
