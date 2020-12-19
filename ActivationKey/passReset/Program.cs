using System;

namespace passReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Done")
            {
                string comand = command[0];
                if (comand == "TakeOdd")
                {
                    string newPass = "";
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPass += input[i];
                        }
                    }
                    input = newPass;
                    Console.WriteLine(input);
                }
                else if (comand == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);
                    string firstPart = input.Substring(0, index);
                    string thirtPart = input.Substring(index + lenght);
                    input = firstPart + thirtPart;
                    Console.WriteLine(input);
                }
                else if (comand == "Substitute")
                {
                    string substring = command[1];
                    string subtitute = command[2];
                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, subtitute);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
