using System;

namespace _06.mathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char operatorInput = Console.ReadLine().Trim()[0];

            switch (operatorInput)
            {
                case '+':
                    int result = N1 + N2;
                    Console.WriteLine("{0} + {1} = {2} - {3}", N1, N2, result, (result % 2 == 0) ? "even" : "odd");
                    break;
                case '-':
                    result = N1 - N2;
                    Console.WriteLine("{0} - {1} = {2} - {3}", N1, N2, result, (result % 2 == 0) ? "even" : "odd");
                    break;
                case '*':
                    result = N1 * N2;
                    Console.WriteLine("{0} * {1} = {2} - {3}", N1, N2, result, (result % 2 == 0) ? "even" : "odd");
                    break;
                case '/':
                    if (N2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", N1);
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2:F2}", N1, N2, (double)N1 / N2);
                    }
                    break;
                case '%':
                    if (N2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", N1);
                    }
                    else
                    {
                        Console.WriteLine("{0} % {1} = {2}", N1, N2, N1 % N2);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    }
}
