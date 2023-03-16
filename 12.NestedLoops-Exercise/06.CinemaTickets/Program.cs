using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student = 0, standard=0, kid=0;
            while (true){
                string name=Console.ReadLine();
                if (name.Equals("Finish"))
                    break;
                int seats = int.Parse(Console.ReadLine());
                int seats2 = 0;
                while (seats2<seats)
                {
                    string type = Console.ReadLine();
                    if (type.Equals("End")) break;
                    else if (type.Equals("student")) student++;
                    else if (type.Equals("standard")) standard++;
                    else if (type.Equals("kid")) kid++;
                    seats2++;
                }
                double percent = ((double)seats2 / seats) * 100;
                Console.WriteLine($"{name} - {percent:f2}% full.");
            }
            int totalTickets = student + standard + kid;
            Console.WriteLine("Total tickets: {0}", totalTickets);
            Console.WriteLine($"{((double)student / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{((double)standard / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{((double)kid / totalTickets) * 100:f2}% kids tickets.");
        }
    }
}
