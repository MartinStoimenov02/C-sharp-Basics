using System;

namespace _04._1.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int money = 0;
            int toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10 * (i / 2);
                    money -= 1;
                }
                else
                {
                    toys++;
                }
            }

            double totalMoney = money + toys * toyPrice;

            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine("Yes! {0:F2}", totalMoney - washingMachinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", washingMachinePrice - totalMoney);
            }
        }
    }
}
