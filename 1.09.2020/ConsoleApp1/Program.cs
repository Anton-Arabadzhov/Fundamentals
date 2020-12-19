using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] arr =  
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (day < 1 || day > arr.Length)
            {
                Console.WriteLine("Invalid day!");

            }
            else
            {
                Console.WriteLine(arr[day - 1]);
            }
        }
    }
}
