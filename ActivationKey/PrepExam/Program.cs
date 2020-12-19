using System;

namespace PrepExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] input = command.Split(">>>");
                if (input[0] == "Contains")
                {
                    string subPart = input[1];
                    if (activationKey.Contains(subPart))
                    {
                        Console.WriteLine($"{activationKey} contains {subPart}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (input[0] == "Flip")
                {
                    if (input[1].ToUpper() == "UPPER")
                    {
                        int startIndex = int.Parse(input[2]);
                        int endIndex = int.Parse(input[3]);

                        string firstSub = activationKey.Substring(0, startIndex);
                        string secondSub = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                        string thirdSub = activationKey.Substring(endIndex);
                        activationKey = firstSub + secondSub + thirdSub;
                        Console.WriteLine($"{activationKey}");
                    }
                    else if (input[1].ToLower() == "lower")
                    {
                        int startIndex = int.Parse(input[2]);
                        int endIndex = int.Parse(input[3]);

                        string firstSub = activationKey.Substring(0, startIndex);
                        string secondSub = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                        string thirdSub = activationKey.Substring(endIndex);
                        activationKey = firstSub + secondSub + thirdSub;
                        Console.WriteLine($"{activationKey}");
                    }

                }
                else if (input[0] == "Slice")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);

                    string firstPart = activationKey.Substring(0, startIndex);
                    string removePart = activationKey.Substring(startIndex, endIndex - startIndex);
                    string secondPart = activationKey.Substring(endIndex);
                    activationKey = firstPart + secondPart;
                    Console.WriteLine($"{activationKey}");
                }



                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
