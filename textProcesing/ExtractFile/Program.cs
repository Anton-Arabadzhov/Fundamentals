using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(@"\");
            string lastFile = arr[arr.Length - 1];
            string[] arr1 = lastFile.Split('.');
            Console.WriteLine($"File name: {arr1[0]}");
            Console.WriteLine($"File extention: {arr1[1]}");
        }
    }
}
