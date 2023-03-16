using System;

namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int etage = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for(int i = etage; i>= 1; i--)
            {
                for(int j = 0; j < rooms; j++)
                {
                    if (i % 2 == 0 && i!=etage)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else if(i == etage)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
