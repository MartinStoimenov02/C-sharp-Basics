using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int br = int.Parse(Console.ReadLine());
            for(int i =0; i < br; i++)
            {
                string gradeName = Console.ReadLine();
                double gradePoints = double.Parse(Console.ReadLine());
                points += ((gradeName.Length * gradePoints) / 2.0);
                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} " +
                        $"got a nominee for leading role with {points:f1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {actorName} " +
                $"you need {(1250.5-points):f1} more!");
        }
    }
}
