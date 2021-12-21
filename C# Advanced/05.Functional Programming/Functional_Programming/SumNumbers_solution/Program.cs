using System;
using System.Linq;

namespace SumNumbers_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);
            int[] n = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();
            Console.WriteLine(n.Length);
            Console.WriteLine(n.Sum());
        }
    }
}
