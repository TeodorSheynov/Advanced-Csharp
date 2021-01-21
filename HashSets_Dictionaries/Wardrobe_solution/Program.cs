using System;
using System.Collections.Generic;

namespace Wardrobe_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int colorsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < colorsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] items = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int k = 0; k < items.Length; k++)
                {
                    if (wardrobe[color].ContainsKey(items[k]))
                    {
                        wardrobe[color][items[k]]++;
                    }
                    else
                    {
                        wardrobe[color].Add(items[k], 1);
                    }

                }
            }
            string[] search = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            foreach (var colorR in wardrobe)
            {
                Console.WriteLine($"{colorR.Key} clothes:");
                foreach (var cloth in colorR.Value)
                {
                    var clothitem = cloth.Key;
                    var clothitemCount = cloth.Value;
                    if (search[0]==colorR.Key && search[1]==cloth.Key)
                    {
                        Console.WriteLine($"* {clothitem} - {clothitemCount} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothitem} - {clothitemCount}");
                    }
                }
            }
        }
    }
}
