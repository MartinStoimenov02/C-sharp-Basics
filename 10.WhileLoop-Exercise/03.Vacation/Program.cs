using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spend = 0;
            while (currentMoney < neededMoney)
            {
                string command = Console.ReadLine();
                double saveSpend = double.Parse(Console.ReadLine());
                if (command.Equals("spend"))
                {
                    spend++;
                    currentMoney -= saveSpend;
                    if (currentMoney < 0)
                        currentMoney = 0;
                }
                    
                else if (command.Equals("save"))
                {
                    spend=0;
                    currentMoney += saveSpend;
                }
                days++;
                if (spend >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    Environment.Exit(1);
                }
            }
            Console.WriteLine($"You saved the money for {days} days.");
        }
    }
}
