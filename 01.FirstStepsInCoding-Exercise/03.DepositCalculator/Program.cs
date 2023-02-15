using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double sum = deposit + srok * ((deposit * percent/100.0) / 12);
            Console.WriteLine(sum);
        }
    }
}