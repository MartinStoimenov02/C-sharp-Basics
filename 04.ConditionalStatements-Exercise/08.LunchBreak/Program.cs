using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int filmLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());
            double freeTime = breakLength-(breakLength/8.0)-(breakLength/4.0);
            double enoughTime = Math.Ceiling(Math.Abs(freeTime-filmLength));
            if (freeTime < filmLength)
            {

                Console.WriteLine($"You don't have enough time to watch {name}, you need {enoughTime:f0} more minutes.");
            }
            else
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {enoughTime:f0} minutes free time.");
            }
        }
    }
}
