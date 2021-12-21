using System;
using System.Collections.Generic;

namespace BracketsBalance_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] brackets = Console.ReadLine().ToCharArray();
            int lenght = 0;
            Queue<char> que = new Queue<char>(brackets);
            Stack<char> stack = new Stack<char>(brackets);
            if (brackets.Length%2!=0)
            {
                Console.WriteLine("NO");
                return;
            }
            else
            {
                lenght = brackets.Length / 2;
            }
            for (int i = 0; i < lenght; i++)
            {
                
                switch(que.Peek())
                {
                    case '{':
                        if (stack.Pop()=='}')
                        {
                            que.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case '(':
                        if (stack.Pop() == ')')
                        {
                            que.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case '[':
                        if (stack.Pop() == ']')
                        {
                            que.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
                
            }
            Console.WriteLine("YES");
        }
    }
}
