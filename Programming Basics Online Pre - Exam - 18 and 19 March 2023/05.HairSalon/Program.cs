using System;

namespace _05.HairSalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int earnedMoney = 0; 

            while (true)
            {
                string service = Console.ReadLine();

                if (service == "closed")
                {
                    break;
                }

                int price = 0;

                if (service == "haircut")
                {
                    string haircutType = Console.ReadLine();

                    if (haircutType == "mens")
                    {
                        price = 15;
                    }
                    else if (haircutType == "ladies")
                    {
                        price = 20;
                    }
                    else if (haircutType == "kids")
                    {
                        price = 10;
                    }
                }
                else if (service == "color")
                {
                    string colorType = Console.ReadLine();

                    if (colorType == "touch up")
                    {
                        price = 20;
                    }
                    else if (colorType == "full color")
                    {
                        price = 30;
                    }
                }

                earnedMoney += price;

                if (earnedMoney >= target)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {earnedMoney}lv.");
                    return; 
                }
            }

            int moneyNeeded = target - earnedMoney;
            Console.WriteLine($"Target not reached! You need {moneyNeeded}lv. more.");
            Console.WriteLine($"Earned money: {earnedMoney}lv.");
        }
    }
}
