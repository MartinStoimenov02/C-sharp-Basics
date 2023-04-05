using System;

namespace _01.PCStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int brRAM = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double finalPrice = cpuPrice + gpuPrice;
            finalPrice -= finalPrice * discount;
            finalPrice += (ramPrice * brRAM);
            finalPrice *= 1.57;
            Console.WriteLine($"Money needed - {finalPrice:f2} leva.");
        }
    }
}
