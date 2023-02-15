using System;

namespace _03.TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int time = hour * 60 + minutes+15;
            int hourResult = time / 60;
            int minutesResult = time % 60;
            if (hourResult >= 24)
            {
                hourResult-=24;
            }
            if (minutesResult < 10)
            {
                Console.WriteLine($"{hourResult}:0{minutesResult}");
            }
            else
            {
                Console.WriteLine($"{hourResult}:{minutesResult}");
            }
        }
    }
}
