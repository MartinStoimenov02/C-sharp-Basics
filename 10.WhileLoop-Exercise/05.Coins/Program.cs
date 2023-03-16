using System;
using System.Diagnostics.CodeAnalysis;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resto = decimal.Parse(Console.ReadLine());
            int br = 0;
            while (resto != 0)
            {
                if (resto / 2 >= 1)
                {
                    resto -= 2;
                    br++;
                    continue;
                }
                else if(resto / 1 >= 1)
                {
                    resto -= 1.0m;
                    br++;
                    continue;
                }
                else if (resto / 0.5m >= 1)
                {
                    resto -= 0.5m;
                    br++;
                    continue;
                }
                else if (resto / 0.2m >= 1)
                {
                    resto -= 0.2m;
                    br++;
                    continue;
                }
                else if (resto / 0.1m >= 1)
                {
                    resto -= 0.1m;
                    br++;
                    continue;
                }
                else if (resto / 0.05m >= 1)
                {
                    resto -= 0.05m;
                    br++;
                    continue;
                }
                else if (resto / 0.02m >= 1)
                {
                    resto -= 0.02m;
                    br++;
                    continue;
                }
                else if (resto / 0.01m >= 1)
                {
                    resto -= 0.01m;
                    br++;
                    continue;
                }
            }
            Console.WriteLine(br);
        }
    }
}
