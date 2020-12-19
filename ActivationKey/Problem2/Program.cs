using System;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            string pattern = @"[!]([A-Z][a-z]{2,})[!]:\[([A-Za-z ]{8,})\]";
            

            


                for (int i = 0; i < num; i++)
                {


                    string input = Console.ReadLine();
                    Match match = Regex.Match(input, pattern);
                    if (match.Success)
                    {
                        string name = match.Groups[1].Value;
                        string chars = match.Groups[2].Value;
                        Console.Write($"{name}: ");
                        foreach (var item in chars)
                        {
                            int numchara = (int)item;
                            Console.Write($"{numchara} ");
                        
                        }

                    }

                    else
                    {
                        Console.Write("The message is invalid");
                    }
                    Console.WriteLine();
                }
            
        }
    }
}
