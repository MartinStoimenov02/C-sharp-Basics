using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double result = number;
            if (number <= 100)
            {
                result += 5;
            }else if (number > 1000)
            {
                result += number * 0.1;
            }
            else
            {
                result += number*0.2;
            }

            if (number % 2 == 0)
            {
                result += 1;
            }
            else if (number%10==5)
            {
                result += 2;
            }

            Console.WriteLine(result-number);
            Console.WriteLine(result);
        }
    }
}
