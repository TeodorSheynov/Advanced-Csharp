using System;

namespace KnightsOfHonor_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> knights = x => Console.WriteLine($"Sir {x}");
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in names)
            {
                knights(item);
            }
        }
    }
}
