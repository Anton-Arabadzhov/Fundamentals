using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] cmd = input.Split(" -> ");
                string company = cmd[0];
                string employeeID = cmd[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }
                if (!companies[company].Contains(employeeID))
                {
                    companies[company].Add(employeeID);
                }
                


                input = Console.ReadLine();
            }
            foreach (var item in companies.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"-- {items}");
                }
            }
        }
    }
}
