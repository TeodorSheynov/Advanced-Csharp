using System;
using System.Linq;

namespace EvenAndOdds_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string commands = Console.ReadLine();
            Predicate<int> zz = Even;
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (commands == "odd")
                {
                    if (!zz(i))
                    {
                        Console.Write(i + " ");
                    }
                }
                if (commands == "even")
                {
                    if (zz(i))
                    {
                        Console.Write(i + " ");
                        
                    }
                }
            }
        }
        private static bool Even(int obj)
        {
            if (obj % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }


}

