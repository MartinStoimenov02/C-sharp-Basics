using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int size = a * b;
            while(size > 0)
            {
                string part = Console.ReadLine();
                if (part.Equals("STOP"))
                {
                    Console.WriteLine("{0} pieces are left.", Math.Abs(size));
                    Environment.Exit(1);
                }
                size -= int.Parse(part);
            }
            Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(size));
        }
    }
}
