using System;
using System.Linq;

namespace SortEvenNumbers_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .Where(z => z % 2 == 0)
                .ToArray();
            Console.WriteLine(string.Join(' ',arr));
        }
    }
}
