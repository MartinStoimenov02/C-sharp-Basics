using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            int br=0;
            for(int i =start; i<=end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    br++;
                    if (i + j == magicalNum)
                    {
                        Console.WriteLine($"Combination N:{br} ({i} + {j} = {magicalNum})");
                        Environment.Exit(1);
                    }
                }
            }
            Console.WriteLine($"{br} combinations - neither equals {magicalNum}");
        }
    }
}
