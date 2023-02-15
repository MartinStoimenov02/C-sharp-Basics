using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, num, max = int.MinValue;
            for(int i = 0 ; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max) max = num;
            }
            if (max == sum-max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + (sum-max));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs((sum-max) - max));
            }
        }
    }
}
