using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            
            Stack<string> stack = new Stack<string>();
            
            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split();
                switch (comand[0])
                {
                    case "1":
                        if (stack.Count!=0)
                        {
                            builder.Append(stack.Peek());
                        }
                        builder.Append(comand[1]);
                        stack.Push(builder.ToString());
                        builder.Clear();
                        break;
                    case "2":
                        builder.Append(stack.Peek());
                        int length = builder.Length - int.Parse(comand[1]);
                        builder.Remove(length, int.Parse(comand[1]));
                        stack.Push(builder.ToString());
                        builder.Clear();
                        break;
                    case "3":
                        Console.WriteLine(stack.Peek()[int.Parse(comand[1])-1]);
                        break;
                    case "4":
                        stack.Pop();
                        break;
                    default:
                        break;
                }
                
            }
        }
    }
}
