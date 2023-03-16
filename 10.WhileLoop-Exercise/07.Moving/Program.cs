using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int vol = width*length*height;
            while (vol > 0)
            {
                string br = Console.ReadLine();
                if (br.Equals("Done"))
                {
                    Console.WriteLine("{0} Cubic meters left.", vol);
                    Environment.Exit(1);
                }
                vol -= int.Parse(br);
            }
            Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(vol));
        }
    }
}
