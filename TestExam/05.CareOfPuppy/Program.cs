using System;
using System.Data;

namespace _05.CareOfPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine())*1000;
            string command = "";
            int eatenFood = 0;

            while (true)
            {
                command=Console.ReadLine();
                if (command.Equals("Adopted")) break;
                eatenFood += int.Parse(command);
            }
            int ostanalo = food - eatenFood;
            if (ostanalo >= 0)
                Console.WriteLine($"Food is enough! Leftovers: {ostanalo} grams.");
            else
                Console.WriteLine($"Food is not enough. You need {Math.Abs(ostanalo)} grams more.");
        }
    }
}
