using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backin30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            
            

            int time = min + 30;
            if (time > 59)
            {
                time = time - 60;
                hour++;
                if (hour > 23)
                {
                    hour = 0;
                }
            }
            Console.WriteLine($"{hour}:{time:d2}");
        }
    }
}
