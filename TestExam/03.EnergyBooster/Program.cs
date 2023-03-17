using System;

namespace _03.EnergyBooster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int br = int.Parse(Console.ReadLine());
            double price=0;
            switch (fruit)
            {
                case "Watermelon":
                    if (set.Equals("small"))
                        price = 2*56;
                    else if(set.Equals("big"))
                        price = 5*28.7;
                    break;
                case "Mango":
                    if (set.Equals("small"))
                        price = 2*36.66;
                    else if (set.Equals("big"))
                        price = 5*19.6;
                    break;
                case "Pineapple":
                    if (set.Equals("small"))
                        price = 2*42.1;
                    else if (set.Equals("big"))
                        price = 5*24.8;
                    break;
                case "Raspberry":
                    if (set.Equals("small"))
                        price = 2*20;
                    else if (set.Equals("big"))
                        price = 5*15.2;
                    break;
            }
            price *= br;
            if (price >= 400 && price<=1000)
                price -= (price * 0.15);
            else if(price>1000)
                price -= (price * 0.5);
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
