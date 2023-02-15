using System;
using System.Threading;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = 0;
            string type = Console.ReadLine();
            if (type.Equals("square"))
            {
                double a = double.Parse(Console.ReadLine());
                area = Math.Pow(a, 2);
            }
            else if (type.Equals("rectangle"))
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (type.Equals("circle"))
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI*Math.Pow(r, 2);
            }
            else if (type.Equals("triangle"))
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = (a * ha)/2.0;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
