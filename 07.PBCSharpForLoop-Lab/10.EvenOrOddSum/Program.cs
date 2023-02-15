using System;

namespace _10.EvenOrOddSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0, sumEven = 0, number;
            for(int i=1; i<=n; i++)
            {
                number=int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes\nSum = {0}", sumEven);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(sumEven - sumOdd));
            }
        }
    }
}
