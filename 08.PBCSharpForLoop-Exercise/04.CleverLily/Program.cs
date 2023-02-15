using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMashine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());
            int toys = 0, money = 0;
            for(int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money+=((5*i)-1);
                }
                else
                {
                    toys+=priceOfToy;
                }
            }
            double savedMoney = money + toys;
            if (savedMoney >= priceOfWashingMashine)
            {
                Console.WriteLine($"Yes! " +
                    $"{(savedMoney - priceOfWashingMashine):f2}");
            }
            else
            {
                Console.WriteLine($"No! " +
                    $"{(priceOfWashingMashine - savedMoney):f2}");
            }
        }
    }
}
