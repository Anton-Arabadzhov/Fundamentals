using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][a-zA-Z0-9]{4,}[A-Z]@#+";
            int number = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < number; i++)
            {
                string empty = "";
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string campere = match.Value;
                    for (int s = 0; s < campere.Length; s++)
                    {
                        if (char.IsDigit(campere[s]))
                        {
                            empty += campere[s];

                        }
                        
                        
                    }
                    if (empty == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {empty}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
                
            }
        }
    }
}
