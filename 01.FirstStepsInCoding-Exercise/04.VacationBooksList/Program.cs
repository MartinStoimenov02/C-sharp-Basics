using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brStr = int.Parse(Console.ReadLine());
            int strHour = int.Parse(Console.ReadLine());
            int brDays = int.Parse(Console.ReadLine());
            double read = (brStr / strHour) / brDays;
            Console.WriteLine(read);
        }
    }
}
