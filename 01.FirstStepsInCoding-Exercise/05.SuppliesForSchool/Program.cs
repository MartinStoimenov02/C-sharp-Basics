using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brPen=int.Parse(Console.ReadLine());
            int brMarkers = int.Parse(Console.ReadLine());
            int litresPrep = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            double price = brPen * 5.8 + brMarkers * 7.2 + litresPrep * 1.2;
            double finalPrice = price - (price * percent * 0.01);
            Console.WriteLine(finalPrice);
        }
    }
}