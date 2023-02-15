using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0;
            switch(type)
            {
                case "Premiere":
                    price = r * c * 12;
                    break;
                case "Normal":
                    price = r * c * 7.5;
                    break;
                case "Discount":
                    price = r * c * 5;
                    break;
            }
            if (price != 0)
            {
                Console.WriteLine($"{price:f2} leva");
            }
        }
    }
}
