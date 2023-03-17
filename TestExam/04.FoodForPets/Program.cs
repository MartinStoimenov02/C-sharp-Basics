using System;

namespace _04.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dogFood = 0;
            double catFood = 0;
            double currentDog;
            double currentCat;
            double biscuites = 0;
            for(int i = 1; i <= days; i++)
            {
                currentDog = double.Parse(Console.ReadLine());
                dogFood += currentDog;
                currentCat = double.Parse(Console.ReadLine());
                catFood += currentCat;
                if (i % 3 == 0)
                    biscuites += (currentDog + currentCat) * 0.1;
            }
            double sum = dogFood + catFood;
            Console.WriteLine($"Total eaten biscuits: {biscuites:f0}gr.");
            Console.WriteLine($"{100.0 * sum / food:f2}% of the food has been eaten.");
            Console.WriteLine($"{100.0 * dogFood / sum:f2}% eaten from the dog.");
            Console.WriteLine($"{100.0 * catFood / sum:f2}% eaten from the cat.");
        }
    }
}
