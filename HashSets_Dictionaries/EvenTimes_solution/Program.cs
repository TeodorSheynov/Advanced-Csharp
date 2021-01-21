using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> hash = new HashSet<int>();
            List<int> list = new List<int>();
            int br = 0;
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n; i++)
            {
                foreach (var item in list)
                {
                    if (list[i]==item)
                    {
                        br++;
                        
                    }
                }
                if (br%2!=0)
                {
                    br = 0;
                }else
                {
                    Console.WriteLine(list[i]);
                    return;
                }
            }
        }
    }
}
