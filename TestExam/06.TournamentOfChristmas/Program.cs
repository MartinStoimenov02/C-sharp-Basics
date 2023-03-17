using System;

namespace _06.TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string command = "";
            string result;
            double dayPrice;
            double price = 0;
            int winBr, loseBr, winDay=0, loseDay=0;
            for(int i = 0; i<days; i++)
            {
                winBr = 0;
                loseBr = 0;
                dayPrice = 0;
                while (true)
                {
                    command = Console.ReadLine();
                    if (command.Equals("Finish")) break;
                    result = Console.ReadLine();
                    if (result.Equals("win"))
                    {
                        dayPrice += 20;
                        winBr++;
                    }

                    else if (result.Equals("lose"))
                        loseBr++;
                }
                if (winBr > loseBr)
                {
                    dayPrice += dayPrice * 0.1;
                    winDay++;
                }
                else if (winBr < loseBr) loseDay++;
                   
                price += dayPrice;
            }
            if (winDay > loseDay)
            {
                price += price * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {price:f2}");
            }
            else
                Console.WriteLine($"You lost the tournament! Total raised money: {price:f2}");
        }
    }
}
