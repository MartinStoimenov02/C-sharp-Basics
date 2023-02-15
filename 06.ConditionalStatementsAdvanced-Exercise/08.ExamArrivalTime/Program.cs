using System;

namespace _08.ExamArrivalTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            int difference = arrivalTime - examTime;

            if (difference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (difference >= -30 && difference < 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", Math.Abs(difference));
            }
            else if (difference > 0)
            {
                Console.WriteLine("Late");
                if (difference < 60)
                {
                    Console.WriteLine("{0} minutes after the start", difference);
                }
                else
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;
                    Console.WriteLine("{0}:{1:D2} hours after the start", hours, minutes);
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (difference > -60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(difference));
                }
                else
                {
                    int hours = Math.Abs(difference) / 60;
                    int minutes = Math.Abs(difference) % 60;
                    Console.WriteLine("{0}:{1:D2} hours before the start", hours, minutes);
                }
            }
        }
    }
}
