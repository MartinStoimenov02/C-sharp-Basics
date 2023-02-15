using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());
            double timeTotal = distance*timeForMeter;
            double slow = Math.Floor(distance/15.0);
            slow *= 12.5;
            timeTotal += slow;
            if (timeTotal < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeTotal:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(timeTotal - record):f2} seconds slower.");
            }
        }
    }
}
