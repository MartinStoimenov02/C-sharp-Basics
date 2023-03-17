using System;

namespace _02.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int walkingTime = int.Parse(Console.ReadLine());
            int br = int.Parse(Console.ReadLine());
            int kalorii = int.Parse(Console.ReadLine());
            int razhodka_kalorii = walkingTime * 5 * br;
            if (razhodka_kalorii >= kalorii*0.5)
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {razhodka_kalorii}.");
            else
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {razhodka_kalorii}.");
        }
    }
}
