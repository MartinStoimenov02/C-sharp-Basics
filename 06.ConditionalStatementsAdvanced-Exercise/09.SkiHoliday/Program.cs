using System;

namespace _09.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0;
            switch (type)
            {
                case "room for one person":
                    price = (days-1) * 18;
                    price = addGrade(price, grade);
                    break;
                case "apartment":
                    price = (days-1) * 25;
                    if (days < 10)
                    {
                        price -= price * 0.3;
                    }else if(days>=10 && days < 15)
                    {
                        price -= price * 0.35;
                    }
                    else
                    {
                        price -= price * 0.5;
                    }
                    price = addGrade(price, grade);
                    break;
                case "president apartment":
                    price = (days - 1) * 35;
                    if (days < 10)
                    {
                        price -= price * 0.1;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        price -= price * 0.15;
                    }
                    else
                    {
                        price -= price * 0.2;
                    }
                    price = addGrade(price, grade);
                    break;
            }

            Console.WriteLine($"{price:f2}");
        }

        public static double addGrade(double price, string grade) {
            if (grade.Equals("positive"))
            {
                return price + 0.25 * price;
            }
            else if (grade.Equals("negative"))
            {
                return price - 0.1 * price;
            }
            return 0;
        }
    }
}
