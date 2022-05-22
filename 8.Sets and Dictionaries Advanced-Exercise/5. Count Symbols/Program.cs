using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            SortedDictionary<char, int> results = new SortedDictionary<char, int>();
            foreach (var character in charArray)
            {
                if (!results.ContainsKey(character))
                {
                    results.Add(character, 0);
                }
                results[character]++;
            }

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key}: {result.Value} time/s");
            }
        }
    }
}
