using System;

namespace _08.NumberRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            int number;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min= number;
                }
            }
            Console.WriteLine("Max number: {0}", max);
            Console.WriteLine("Min number: {0}", min);
        }
    }
}
