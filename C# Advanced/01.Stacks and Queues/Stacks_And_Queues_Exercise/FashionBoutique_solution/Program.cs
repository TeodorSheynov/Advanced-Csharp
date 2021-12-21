using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int capacity = int.Parse(Console.ReadLine());
            int sum=0;
            int br=0;

            while (stack.Count>0)
            {
                if (sum+stack.Peek()>capacity)
                {
                    sum = 0;
                    br++;
                }else
                {
                    sum += stack.Pop();
                    
                }
            }
            if (sum!=0)
            {
                br++;
            }
            Console.WriteLine(br);
        }
    }
}
