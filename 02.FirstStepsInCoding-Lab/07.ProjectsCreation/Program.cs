using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int br = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need {br*3} hours to complete {br} project/s.");
        }
    }
}
