using System;

namespace _03.NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int br = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            switch(type)
            {
                case "Roses":
                    price = br * 5;
                    if (br > 80)
                    {
                        price -= price * 0.1;
                    }
                    break;

                case "Dahlias":
                    price = br * 3.8;
                    if (br > 90)
                    {
                        price -= price * 0.15;
                    }
                    break;

                case "Tulips":
                    price = br * 2.8;
                    if (br > 80)
                    {
                        price -= price * 0.15;
                    }
                    break;

                case "Narcissus":
                    price = br * 3;
                    if (br < 120)
                    {
                        price += price * 0.15;
                    }
                    break;

                case "Gladiolus":
                    price = br * 2.5;
                    if (br < 80)
                    {
                        price += price * 0.2;
                    }
                    break;
            }

            if (price == 0)
            {
                return;
            }

            if (budget >= price)
                Console.WriteLine($"Hey, you have a great garden with {br} {type} and {(budget - price):f2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
        }
    }
}
