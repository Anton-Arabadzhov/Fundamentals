using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] listOfPeople = Console.ReadLine().Split(", ");
            Dictionary<string, int> dictionaryOfNames = new Dictionary<string, int>();

            string pattern = @"[\W\d]";
            string numberpattern = @"[\WA-Za-z]";

            /*  pattern match symbols & digits
             *  numberpattern match symbols & characters
              G4e@55or%6g6!68e!!@
               R1@!3a$y4456@
               B5@i@#123ll
               G@e54o$r6ge#
               7P%et^#e5346r
               T$o553m&6
            */



            foreach (var name in listOfPeople)
            {
                dictionaryOfNames.Add(name, 0);
            }
            string input = Console.ReadLine();
            

            while (input != "end of race")
            {
                string name = Regex.Replace(input, pattern, "");
                string distance = Regex.Replace(input, numberpattern, "");
                int sum = 0;
                foreach (var digit in distance)
                {
                    int currDigit = int.Parse(digit.ToString());
                    sum += currDigit;
                }

                if (dictionaryOfNames.ContainsKey(name))
                {
                    dictionaryOfNames[name] += sum;
                }
                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var kvp in dictionaryOfNames.OrderByDescending(x=>x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                /*  
                   tova e ravno na po gornoto
                   string output = "";
                    if (count == 1)
                    {
                        output = "st";
                count++;
                    }
                    else if (count == 2)
                    {
                        output = "nd";
                count++;
                    }
                    else if (count == 3)
                    {
                        output = "rd";
                count++;
                    }
                */
            Console.WriteLine($"{count++}{text} place: {kvp.Key}");
                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}
