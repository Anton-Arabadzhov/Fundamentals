using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOperator = int.Parse(Console.ReadLine());
            int secondOperator = int.Parse(Console.ReadLine());
            int thirtOperator = int.Parse(Console.ReadLine());
            int totalCostumers = int.Parse(Console.ReadLine());
            int counter = 0;
            while (totalCostumers > 0)
            {
                int pplPerHour = firstOperator+secondOperator+thirtOperator;
                totalCostumers -= pplPerHour;
                counter++;
                if (counter % 4 == 0)
                {
                    counter++;
                }
                if (totalCostumers <= 0)
                {
                    break;
                }
                
                

            }
            Console.WriteLine($"Time needed: {counter}h.");

        }
    }
}
