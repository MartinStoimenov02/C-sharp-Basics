using System;
using System.Security;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double vol = (length*width*height)/1000.0;
            double litres = vol - (vol * (percent / 100.0));
            Console.WriteLine($"{litres:f2}");
        }
    }
}