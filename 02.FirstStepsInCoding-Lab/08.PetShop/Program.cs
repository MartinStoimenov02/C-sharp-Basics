using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brDog = int.Parse(Console.ReadLine());
            int brCat = int.Parse(Console.ReadLine());
            double price = brDog * 2.5 + brCat * 4;
            Console.WriteLine($"{price} lv.");
        }
    }
}
