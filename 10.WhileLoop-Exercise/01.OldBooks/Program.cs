using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myBook = Console.ReadLine();
            int count = 0;
            while (true)
            {
                string otherBook = Console.ReadLine();
                if (otherBook.Equals(myBook))
                {
                    Console.WriteLine("You checked {0} " +
                        "books and found it.", count);
                    break;
                }
                if(otherBook.Equals("No More Books"))
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine("You checked {0} books.", count);
                    break;
                }
                count++;
            }
        }
    }
}
