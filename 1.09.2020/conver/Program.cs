using System;

namespace P01_CenturiesToMinutes
{
    class P01_CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            string aski = "";
            

            for (int i = first; i <= second; i++)
            {
                char c = (char)i;

                aski += ($"{c} ".Select(int.Parse));
                
            }
            Console.WriteLine(aski);
        }
    }
}
