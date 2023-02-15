using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearPrice = int.Parse(Console.ReadLine());
            double kec = yearPrice - yearPrice * 0.4;
            double ekip = kec - kec * 0.2;
            double ball = ekip / 4.0;
            double acsesoari = ball / 5.0;
            double finalPrice = yearPrice + kec + ekip + ball + acsesoari;
            Console.WriteLine(finalPrice);
        }
    }
}
