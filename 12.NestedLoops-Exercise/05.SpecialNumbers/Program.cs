using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1111; i <= 9999; i++)
            {
                int num = i;
                bool flag = true;
                while (num != 0)
                {
                    int digit = (num % 10);
                    if (digit == 0 || n % digit != 0)
                    {
                        flag = false;
                        break;
                    }
                   
                    num = num / 10;
                }
                if (flag)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
