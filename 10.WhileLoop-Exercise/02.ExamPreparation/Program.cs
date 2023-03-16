using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failGrades=int.Parse(Console.ReadLine());
            int failGradesCount = 0;
            int countProblems = 0;
            double sum = 0;
            string lastProblem="";
            while (true)
            {
                string name = Console.ReadLine();
                if (name.Equals("Enough"))
                {
                    Console.WriteLine($"Average score: {sum / countProblems:f2}");
                    Console.WriteLine("Number of problems: {0}", countProblems);
                    Console.WriteLine("Last problem: " + lastProblem);
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                    failGradesCount++;
                if (failGrades == failGradesCount)
                {
                    Console.WriteLine("You need a break, {0} poor grades.", failGrades);
                    break;
                }
                lastProblem = name;
                sum += grade;
                countProblems++;
            }
        }
    }
}
