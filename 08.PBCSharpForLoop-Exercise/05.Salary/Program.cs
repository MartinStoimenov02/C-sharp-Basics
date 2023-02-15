using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string tab = Console.ReadLine();
                if (tab.Equals("Facebook"))
                    salary -= 150;
                else if (tab.Equals("Instagram"))
                    salary -= 100;
                else if (tab.Equals("Reddit"))
                    salary -= 50;
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(salary);
        }
    }
}
