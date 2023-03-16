using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brGrupi = int.Parse(Console.ReadLine());
            int musala = 0, monblan = 0, kilim = 0, k2 = 0, everest = 0, obsht=0;
            for(int i = 0; i<brGrupi; i++)
            {
                int br = int.Parse(Console.ReadLine());
                obsht += br;
                if (br <= 5)
                    musala += br;
                else if(br>5 && br <= 12)
                    monblan+= br;
                else if(br>12 && br <= 25)
                    kilim += br;
                else if(br>25 && br<=40)
                    k2 += br;
                else everest += br;
            }
            Console.WriteLine($"{(((double)musala /obsht)*100):f2}%");
            Console.WriteLine($"{(((double)monblan / obsht) * 100):f2}%");
            Console.WriteLine($"{(((double)kilim / obsht) * 100):f2}%");
            Console.WriteLine($"{(((double)k2 / obsht) * 100):f2}%");
            Console.WriteLine($"{(((double)everest / obsht) * 100):f2}%");
        }
    }
}
