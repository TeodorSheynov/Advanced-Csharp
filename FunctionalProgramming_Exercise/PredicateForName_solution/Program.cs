using System;
using System.Linq;

namespace PredicateForName_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Func<string,bool> predicate = x => x.Length <= size;
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var predicateNames = names.Where(predicate);
            foreach (var item in predicateNames)
            {
                Console.WriteLine(item);
            }
                
        }
    }
}
