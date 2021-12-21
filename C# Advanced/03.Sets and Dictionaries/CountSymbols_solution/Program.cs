using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            HashSet<char> hash = new HashSet<char>(n.ToCharArray());
            int br = 0;


            foreach (var item in hash.OrderBy(x=>x))
            {
                foreach (var character in n.ToCharArray())
                {
                    if (item==character)
                    {
                        br++;
                    }
                }
                Console.WriteLine($"{item}: {br} time/s");
                br = 0;
            }
 
        }
    }
}

