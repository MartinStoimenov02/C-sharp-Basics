using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double commission = 0;
            switch (city)
            {
                case "Sofia":
                    if (salesVolume >= 0 && salesVolume <= 500)
                        commission = salesVolume * 0.05;
                    if (salesVolume > 500 && salesVolume <= 1000)
                        commission = salesVolume * 0.07;
                    if (salesVolume > 1000 && salesVolume <= 10000)
                        commission = salesVolume * 0.08;
                    if (salesVolume > 10000)
                        commission = salesVolume * 0.12;
                    break;
                case "Varna":
                    if (salesVolume >= 0 && salesVolume <= 500)
                        commission = salesVolume * 0.045;
                    if (salesVolume > 500 && salesVolume <= 1000)
                        commission = salesVolume * 0.075;
                    if (salesVolume > 1000 && salesVolume <= 10000)
                        commission = salesVolume * 0.1;
                    if (salesVolume > 10000)
                        commission = salesVolume * 0.13;
                    break;
                case "Plovdiv":
                    if (salesVolume >= 0 && salesVolume <= 500)
                        commission = salesVolume * 0.055;
                    if (salesVolume > 500 && salesVolume <= 1000)
                        commission = salesVolume * 0.08;
                    if (salesVolume > 1000 && salesVolume <= 10000)
                        commission = salesVolume * 0.12;
                    if (salesVolume > 10000)
                        commission = salesVolume * 0.145;
                    break;
            }

            if (commission == 0)
            {
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine($"{commission:f2}");
        }
    }
}
