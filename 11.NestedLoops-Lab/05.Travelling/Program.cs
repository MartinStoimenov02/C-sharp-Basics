using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }

                double budget = double.Parse(Console.ReadLine());
                double savings = 0;

                while (savings < budget)
                {
                    double currentSavings = double.Parse(Console.ReadLine());
                    savings += currentSavings;
                }

                Console.WriteLine($"Going to {destination}!");
            }

        }
    }
}
