using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int boya = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int brHours = int.Parse(Console.ReadLine());
            double priceProducts = (naylon + 2) * 1.5 + (boya + boya * 0.1) * 14.50 + razreditel * 5 + 0.4;
            double finalPrice = (priceProducts * 0.3) * brHours+priceProducts;
            Console.WriteLine(finalPrice);
        }
    }
}
