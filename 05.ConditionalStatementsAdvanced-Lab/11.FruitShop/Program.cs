using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double br = double.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit.Equals("banana"))
                        price = 2.5*br;
                    if (fruit.Equals("apple"))
                        price = 1.2 * br;
                    if (fruit.Equals("orange"))
                        price = 0.85 * br;
                    if (fruit.Equals("grapefruit"))
                        price = 1.45 * br;
                    if (fruit.Equals("kiwi"))
                        price = 2.7 * br;
                    if (fruit.Equals("pineapple"))
                        price = 5.5 * br;
                    if (fruit.Equals("grapes"))
                        price = 3.85 * br;
                    break;
                case "Saturday":
                case "Sunday":
                    if (fruit.Equals("banana"))
                        price = 2.7 * br;
                    if (fruit.Equals("apple"))
                        price = 1.25 * br;
                    if (fruit.Equals("orange"))
                        price = 0.9 * br;    
                    if (fruit.Equals("grapefruit"))
                        price = 1.6 * br;
                    if (fruit.Equals("kiwi"))
                        price = 3 * br;
                    if (fruit.Equals("pineapple"))
                        price = 5.6 * br;
                    if (fruit.Equals("grapes"))
                        price = 4.2 * br;
                    break;
            }
            if (price == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
