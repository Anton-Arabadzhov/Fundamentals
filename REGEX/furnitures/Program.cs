using System;
using System.Text.RegularExpressions;

namespace Furniture

{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>\b([A-Za-z]+)<<([0-9]+\.?[0-9]*)!([0-9]+)";
            /*
         match >>Sofa<<312.23!3
         match >>TV<<300!5
         unmatch >Invalid<<!5
                Purchase

             */
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            double sum = 0;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int count = int.Parse(match.Groups[3].Value);
                    Console.WriteLine(name);
                    sum += price * count;
                }
                
                input = Console.ReadLine();

            }
            Console.WriteLine($"Total money spend: {sum:f2}");

        }
    }
}