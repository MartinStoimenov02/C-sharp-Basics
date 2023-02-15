using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int br = int.Parse(Console.ReadLine());
            double apartment=0;
            double studio=0;
            switch (month)
            {
                case "May":
                case "October":
                    studio = setStudioPrice(50, br, 1);
                    apartment = setApartmentPrice(65, br);
                    break;
                case "June":
                case "September":
                    studio = setStudioPrice(75.2, br, 2);
                    apartment = setApartmentPrice(68.7, br);
                    break;
                case "July":
                case "August":
                    studio = setStudioPrice(76, br, 0);
                    apartment = setApartmentPrice(77, br);
                    break;
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }

        public static double setApartmentPrice(double price, int br)
        {
            //double apartment = price * br;
            //if (br > 14)
            //{
            //    apartment -= apartment * 0.1;
            //}
            return (br > 14) ? (price * br) - (price * br) * 0.1 : (price * br);
        }

        public static double setStudioPrice(double price, int br, int discount) {
            double studio = br * price;
            if((br>7 && br <= 14) && discount == 1)
            {
                studio -= studio * 0.05;
            }
            if(br > 14)
            {
                if (discount == 1)
                {
                    studio -= studio * 0.3;
                }
                else if(discount == 2)
                {
                    studio -= studio * 0.2;
                }
            }
            return studio;
        }
    }
}
