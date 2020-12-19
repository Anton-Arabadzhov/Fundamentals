using System;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] comarg = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string action = comarg[0];

                if (action == "Replace")
                {
                    
                    string replace = comarg[1];
                    string replacer = comarg[2];
                    
                    input = input.Replace(replace,replacer);
                    Console.WriteLine(input);
                }
                else if (action == "Cut")
                {
                    int startindex = int.Parse(comarg[1]);
                    int endIndex = int.Parse(comarg[2]);
                    if (endIndex > input.Length || endIndex < startindex || startindex < 0)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        string firstPart = input.Substring(0, startindex);
                        string secondPart = input.Substring(startindex, (endIndex - startindex));
                        string thirtpart = input.Substring(endIndex +1);
                        input = firstPart + thirtpart;
                        Console.WriteLine(input);
                    }
                }
                else if (action == "Make")
                {
                    string to = comarg[1];
                    if (to == "Upper")
                    {
                        input = input.ToUpper();
                    }
                    else
                    {
                        input = input.ToLower();
                    }
                    Console.WriteLine(input);
                }
                else if (action == "Check")
                {
                    string check = comarg[1];
                    if (input.Contains(check))
                    {
                        Console.WriteLine($"Message contains {check}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {check}");
                    }
                }
                else if (action == "Sum")
                {
                    int startindex = int.Parse(comarg[1]);
                    int endindex = int.Parse(comarg[2]);
                    if (startindex > input.Length || endindex > input.Length || startindex < 0 || endindex < 0 || startindex > endindex)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                         string sub = input.Substring(startindex, endindex);
                        int result = 0;
                        foreach (var item in sub)
                        {
                            int num = (int)item;
                            result += num;
                        }
                        Console.WriteLine(result);
                    }
                }
                command = Console.ReadLine();
            }
            
        }
            
        

    }
}
