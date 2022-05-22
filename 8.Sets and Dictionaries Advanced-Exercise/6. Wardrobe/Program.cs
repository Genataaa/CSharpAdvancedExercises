using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string colorr = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(colorr))
                {
                    wardrobe.Add(colorr, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[colorr].ContainsKey(clothes[j]))
                    {
                        wardrobe[colorr].Add(clothes[j], 0);
                    }
                    wardrobe[colorr][clothes[j]]++;
                }
            }

            string[] clothesToCheck = Console.ReadLine().Split();
            string color = clothesToCheck[0];
            string typeClothes = clothesToCheck[1];

            foreach (var colorKey in wardrobe)
            {
                Console.WriteLine($"{colorKey.Key} clothes:");
                foreach (var item in colorKey.Value)
                {
                    if (colorKey.Key == color && item.Key == typeClothes)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }
            }
        }
    }
}
