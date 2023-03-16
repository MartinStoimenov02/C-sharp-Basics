using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalGrade = 0;
            int presentationsCount = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                    break;

                double gradesSum = 0;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradesSum += grade;
                }
                double averageGrade = gradesSum / n;
                Console.WriteLine($"{input} - {averageGrade:F2}.");

                totalGrade += averageGrade;

                presentationsCount++;
            }

            double averageTotalGrade = totalGrade / presentationsCount;

            Console.WriteLine($"Student's final assessment is {averageTotalGrade:F2}.");
        }
    }
}
