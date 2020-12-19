using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teathre
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int money = 0;
            if (day == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    money = 12;
                }
                if (age > 18 && age <= 64)
                {
                    money = 18;
                }
                if (age > 64 && age <= 122)
                {
                    money = 12;
                }
            }
            if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    money = 15;
                }
                if (age > 18 && age <= 64)
                {
                    money = 20;
                }
                if (age > 64 && age <= 122)
                {
                    money = 15;
                }
            }
            if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    money = 5;
                }
                if (age > 18 && age <= 64)
                {
                    money = 12;
                }
                if (age > 64 && age <= 122)
                {
                    money = 10;
                }
            }
            if (money == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{money}$");
            }


        }
    }
}
