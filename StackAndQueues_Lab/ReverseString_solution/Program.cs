using System;
using System.Collections.Generic;

namespace ReverseString_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> x = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                x.Push(input[i]);
            }
            foreach (var item in x)
            {
                Console.Write(item);
            }
        }
    }
}
