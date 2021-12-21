using System;
using System.Linq;

namespace VAT_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vat = x => x = x + x * 0.2;
            Func<string, double> parser = x => double.Parse(x);
            double[] arr = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(parser)
                 .Select(vat)
                 .ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
