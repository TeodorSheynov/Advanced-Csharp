using System;
using System.Linq;

namespace CountUpperCase_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isupper = x => x[0] == x.ToUpper()[0];
            string input = Console.ReadLine();
            string[] upperWords = input
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(isupper)
                .ToArray();
            foreach (var item in upperWords)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
