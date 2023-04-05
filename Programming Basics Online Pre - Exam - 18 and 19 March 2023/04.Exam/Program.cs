using System;

namespace _04.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gr1 = 0, gr2 = 0, gr3 = 0, gr4 = 0;
            double uspeh = 0;
            double grade;
            int brStudents = int.Parse(Console.ReadLine());
            for(int i = 1; i<=brStudents; i++)
            {
                grade=double.Parse(Console.ReadLine());
                uspeh += grade;
                if (grade < 3)
                    gr4++;
                else if (grade >= 3 && grade < 4)
                    gr3++;
                else if (grade >= 4 && grade < 5)
                    gr2++;
                else gr1++;
            }
            Console.WriteLine($"Top students: {(gr1*100.0)/brStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(gr2 * 100.0) / brStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(gr3 * 100.0) / brStudents:f2}%");
            Console.WriteLine($"Fail: {(gr4 * 100.0) / brStudents:f2}%");
            Console.WriteLine($"Average: {(uspeh / brStudents):f2}");
        }
    }
}
