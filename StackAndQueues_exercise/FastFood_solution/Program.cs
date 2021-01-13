using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> que = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());
            Console.WriteLine(que.Max());
            while (que.Count>0)
            {

                if (food - que.Peek() >= 0)
                {
                    food -= que.Dequeue();
                }
                else
                {
                    break;
                }
            }
            
            if (que.Count!=0)
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ",que));
            }else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
