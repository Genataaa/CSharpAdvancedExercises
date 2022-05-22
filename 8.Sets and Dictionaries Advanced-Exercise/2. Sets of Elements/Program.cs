using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstHash = new HashSet<int>();
            HashSet<int> secondHash = new HashSet<int>();

            for (int i = 0; i < array[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstHash.Add(input);
            }

            for (int i = 0; i < array[1]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                secondHash.Add(input);
            }

            HashSet<int> result = new HashSet<int>();
            foreach (var currentNum in firstHash)
            {
                if (secondHash.Contains(currentNum))
                {
                    result.Add(currentNum);
                }
            }

            Console.WriteLine(string.Join(" ", re));
        }
    }
}
