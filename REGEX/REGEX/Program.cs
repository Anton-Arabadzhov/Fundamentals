using System;
using System.Text.RegularExpressions;

namespace Furniture

{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>\b([A-Za-z]+)<<([0-9]+\.?[0-9]+?)!([0-9]+)";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var values = regex.Matches(input);
            Console.WriteLine("Bought furniture");
            while (input != "Purchase")
            {
               
                
                    Console.WriteLine($"{values}");
                
                
                
            }

        }
    }
}
