using System;

namespace _09.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            if(productName.Equals("banana") || productName.Equals("apple") || productName.Equals("kiwi") || productName.Equals("cherry") || productName.Equals("lemon") || productName.Equals("grapes"))
            {
                Console.WriteLine("fruit");
            }else if(productName.Equals("tomato") || productName.Equals("cucumber") || productName.Equals("pepper") || productName.Equals("carrot"))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
