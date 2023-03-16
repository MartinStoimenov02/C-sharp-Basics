using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start  = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for(int i = start; i <= end; i++)
            {
                string num = i.ToString();
                int odd = 0, even = 0;
                for(int j = 0; j < num.Length; j++)
                {
                    int currentNum = int.Parse(num[j].ToString());
                    if (j % 2 == 0)
                    {
                        even += currentNum;
                    }
                    else
                    {
                        odd += currentNum;
                    }
                }
                if (odd == even)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
