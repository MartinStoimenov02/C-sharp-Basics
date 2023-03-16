using System;

namespace _08.Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            int turniri = 0;
            int win = 0;
            for (int i = 0; i < br; i++)
            {
                string etap = Console.ReadLine();
                if (etap.Equals("F"))
                    turniri += 1200;
                else if (etap.Equals("W"))
                {
                    turniri += 2000;
                    win++;
                }
                else if (etap.Equals("SF"))
                    turniri += 720;
            }
            Console.WriteLine("Final points: {0}", turniri + start);
            Console.WriteLine("Average points: {0}", turniri / br);
            Console.WriteLine($"{((double)win / br)*100:f2}%");
        }
    }
}
