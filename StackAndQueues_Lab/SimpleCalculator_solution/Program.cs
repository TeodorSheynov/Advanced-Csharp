using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(input.Reverse());
            while (stack.Count>1)
            {
                int operand = int.Parse(stack.Pop());
                string @operator = stack.Pop();
                int operand2 = int.Parse(stack.Pop());
                switch (@operator)
                {
                    case "+":
                        stack.Push((operand + operand2).ToString());
                        break;
                    case "-":
                        stack.Push((operand - operand2).ToString());
                        break;
                    default:
                        throw new Exception("Invalid operator!");
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
