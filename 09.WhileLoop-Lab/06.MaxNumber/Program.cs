using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int max=int.MinValue;
            while (!command.Equals("Stop"))
            {
                int num = int.Parse(command);
                if (num > max)
                    max = num;
                command = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
