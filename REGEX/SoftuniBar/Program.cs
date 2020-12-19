using System;
using System.Text.RegularExpressions;

namespace SoftuniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";
            /*
         match        %George%<Croissant>|2|10.3$
         match        %Peter%<Gum>|1|1.3$
         match        %Maria%<Cola>|1|2.4$
         unmatch      %Valid%<Valid>valid|10|valid20$
             */
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            double total = 0;

            while (input != "end of shift")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    double sumOfMatch = count * price;
                    total += sumOfMatch;
                    Console.WriteLine($"{name}: {product} - {sumOfMatch:f2}");
                }





                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
