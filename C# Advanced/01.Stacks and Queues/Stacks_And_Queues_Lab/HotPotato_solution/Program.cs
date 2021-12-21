using System;
using System.Collections.Generic;

namespace HotPotato_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playerNames = Console.ReadLine().Split();
            int tosses = int.Parse(Console.ReadLine());
            Queue<string> potato = new Queue<string>(playerNames);
            while (potato.Count>1)
            {
                for (int i = 1; i <tosses ; i++)
                {
                    potato.Enqueue(potato.Dequeue());
                }
                Console.WriteLine($"Removed {potato.Dequeue()}");
            }
            Console.WriteLine($"Last is {potato.Peek()}");
            
        }
    }
}
