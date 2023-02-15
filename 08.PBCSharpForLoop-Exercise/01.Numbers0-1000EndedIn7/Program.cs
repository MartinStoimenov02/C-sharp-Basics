using System;

namespace _01.Numbers0_1000EndedIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 7; i <= 1000; i++)
                if(i%10==7)
                    Console.WriteLine(i);
        }
    }
}
