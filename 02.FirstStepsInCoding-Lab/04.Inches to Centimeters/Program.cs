using System;
using System.Threading;

namespace _04.Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches=double.Parse(Console.ReadLine());
            double cm = inches * 2.54;
            Console.WriteLine(cm);
        }
    }
}
