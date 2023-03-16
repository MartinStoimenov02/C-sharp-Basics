using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            double sum=0;
            while (!command.Equals("NoMoreMoney"))
            {
                double num=double.Parse(command);
                if(num<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += num;
                Console.WriteLine($"Increase: {num:f2}");
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
