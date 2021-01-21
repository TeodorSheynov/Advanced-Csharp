using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> periodicTable = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] collection = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in collection)
                {
                    periodicTable.Add(item);
                }
                
            }
            Console.WriteLine(string.Join(' ',periodicTable.OrderBy(x=>x)));
        }
    }
}
