using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arr);
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0]!="end")
            {
                switch (command[0])
                {
                    case "add":
                        stack.Push(int.Parse(command[1]));
                        stack.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        if (stack.Count < int.Parse(command[1]))
                        {
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(command[1]); i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                    default:

                        throw new Exception("Not Allowed Operation!");
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
