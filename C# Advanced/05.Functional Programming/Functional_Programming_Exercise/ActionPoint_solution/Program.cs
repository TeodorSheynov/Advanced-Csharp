using System;
using System.Linq;

namespace ActionPoint_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> newLine = x => Console.WriteLine(x);
            string[] names = Console.ReadLine().Split();
            foreach (var item in names)
            {
                newLine(item);
            }
            
        }
    }
}
