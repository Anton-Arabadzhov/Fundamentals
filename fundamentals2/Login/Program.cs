using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = Console.ReadLine();
            string pass = string.Empty;

            for (int i = login.Length - 1; i >= 0; i--)
            {
                pass += login[i];
            }
            int count = 0;
            while (true)
            {
                string password = Console.ReadLine();
                if (password != pass)
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"User {login} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"User {login} logged in.");
                    break;
                }
            }
            
        }
    }
}
