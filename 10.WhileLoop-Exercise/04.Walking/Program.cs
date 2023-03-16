using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsCount=0;
            while (stepsCount < 10000)
            {
                string steps = Console.ReadLine();
                if(steps.Equals("Going home"))
                {
                    stepsCount += int.Parse(Console.ReadLine());
                    break;
                }
                stepsCount += int.Parse(steps);
            }
            int total = stepsCount - 10000;
            if (total >= 0)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine("{0} steps over the goal!", stepsCount-10000);
            }
            else
            {
                Console.WriteLine("{0} more steps to reach goal.", Math.Abs(total));
            }
            
        }
    }
}
