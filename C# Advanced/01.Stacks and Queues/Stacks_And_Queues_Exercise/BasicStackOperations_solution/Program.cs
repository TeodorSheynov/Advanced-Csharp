using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputNumbers= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(inputNumbers);

            int length = input[0];
            int popCount = input[1];
            int present = input[2];


            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }
            if (stack.Count()==0)
            {
                Console.WriteLine(0);
            }else if (stack.Contains(present))
            {
                Console.WriteLine("true");
            }else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
