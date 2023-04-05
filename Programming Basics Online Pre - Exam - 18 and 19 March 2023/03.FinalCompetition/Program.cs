using System;

namespace _03.FinalCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brDancers = int.Parse(Console.ReadLine());
            double brPoints = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double price = brDancers * brPoints;
            if (!place.Equals("Bulgaria"))
                price += price * 0.5;
            switch (season)
            {
                case "summer":
                    if (place.Equals("Bulgaria"))
                        price -= price * 0.05;
                    else
                        price -= price * 0.1;
                    break;
                case "winter":
                    if (place.Equals("Bulgaria"))
                        price -= price * 0.08;
                    else
                        price -= price * 0.15;
                    break;
            }
            Console.WriteLine($"Charity - {(price*0.75):f2}");
            Console.WriteLine($"Money per dancer - {((price*0.25)/brDancers):f2}");
        }
    }
}
