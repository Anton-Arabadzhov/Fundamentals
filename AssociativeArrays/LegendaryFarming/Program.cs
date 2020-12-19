using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> collects = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();

            collects["shards"] = 0;
            collects["motes"] = 0;
            collects["fragments"] = 0;

            bool isIbtained = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length;i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string matirials = input[i + 1].ToLower();

                    if (matirials == "shards" || matirials == "motes" || matirials == "fragments")
                    {
                        collects[matirials] += quantity;
                        if (collects[matirials] >= 250)
                        {
                            collects[matirials] -= 250;
                            if (matirials == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (matirials == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (matirials == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            isIbtained = true;
                            break;
                        }
                    }
                    
                    else
                    {
                        if (!junks.ContainsKey(matirials))
                        {
                            junks.Add(matirials, quantity);
                        }
                        else
                        {
                            junks[matirials] += quantity;
                        }
                    }
                }
                if (isIbtained)
                {
                    break;
                }
            }
            Dictionary<string, int> filterMaterials = collects
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);
            foreach (var item in filterMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junks.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
