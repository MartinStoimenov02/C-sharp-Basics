using System;
using System.Diagnostics.CodeAnalysis;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clas = 0;
            double sum = 0;
            int exclude = 0;
            while (clas < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                    exclude++;
                if (exclude >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at " +
                        $"{clas} grade");
                    Environment.Exit(1);
                }
                sum += grade;
                clas++;
            }
            Console.WriteLine($"{name} graduated. Average " +
                $"grade: {sum / clas:f2}");
        }
    }
}
