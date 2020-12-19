using System;

namespace TheIminationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] tools = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = tools[0];
                if (action == "Move")
                {
                    int numOfLetter = int.Parse(tools[1]);
                     string subPart = input.Substring(0, numOfLetter);
                     input = input.Remove(0, numOfLetter);
                    input = input + subPart;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(tools[1]);
                    string value = tools[2];
                    input = input.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = tools[1];
                    string replacement = tools[2];
                    input = input.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}

