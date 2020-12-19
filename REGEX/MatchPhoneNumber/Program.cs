using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([- ])2\1([0-9]{3})\1([0-9]{4})\b";

            string input = Console.ReadLine();

            MatchCollection result = Regex.Matches(input, pattern);

            var matchedPhones = result
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
