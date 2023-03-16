using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 1;
            bool stop = false;
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (br > n)
                    {
                        stop=true;
                        break;
                    }
                    Console.Write((br++) + " ");
                }
                if(stop) break;
                Console.WriteLine();
            }
        }
    }
}
