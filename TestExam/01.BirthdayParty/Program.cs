using System;

namespace _01.BirthdayParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double torta = price * 0.2;
            double drink = torta - (torta * 0.45);
            double animator = price * (1 / 3.0);
            Console.WriteLine(price + torta + drink + animator);
        }
    }
}
