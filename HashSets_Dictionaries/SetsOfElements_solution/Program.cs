using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split((' '), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> setOne = new HashSet<int>(n[0]);
            HashSet<int> setTwo = new HashSet<int>(n[1]);
            for (int i = 0; i < n[0]; i++)
            {
                setOne.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n[1]; i++)
            {
                setTwo.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in setOne)
            {
                if (setTwo.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
