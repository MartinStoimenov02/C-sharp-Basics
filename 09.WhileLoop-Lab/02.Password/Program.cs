using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            while (!password.Equals(input))
            {
                input = Console.ReadLine();
            }
            Console.WriteLine("Welcome {0}!", username);
        }
    }
}
