using System;

namespace _02.BraceletStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double sellProfit = double.Parse(Console.ReadLine());
            double expense = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double finalPrice = 5 * (pocketMoney + sellProfit) - expense;
            double isEnough = finalPrice - giftPrice;
            if (isEnough >= 0)
                Console.WriteLine($"Profit: {finalPrice:f2} BGN, the gift has been purchased.");
            else Console.WriteLine($"Insufficient money: {Math.Abs(isEnough):f2} BGN.");
        }
    }
}
