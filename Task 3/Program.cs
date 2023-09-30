using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance traveled : ");
            string input = Console.ReadLine();
            int km;
            double cons, price;
            if (int.TryParse(input, out km))
            {
                cons = Travel.Consumption(km);
                price = Travel.Price(km);
                Console.WriteLine("Fuel consumption is " + cons + " liters and it costs " + price + " euros.");
            }

            else
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }

    public static class Travel
    {
        private static double cons;
        private static double price;
        public static double Consumption(int km)
        {
            Random rnd = new Random();
            cons = rnd.Next(6, 9);
            cons = km * (cons / 100);
            return cons;
        }
        public static double Price(int km)
        {
            Random rnd = new Random();
            price = rnd.Next(175, 250);
            price = cons * (price / 100);
            price = Math.Round(price, 2);
            return price;
        }
    }
}
