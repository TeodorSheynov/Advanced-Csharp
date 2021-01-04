using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> que = new Queue<int>(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (que.Peek()%2==0)
                {
                    que.Enqueue(que.Dequeue());
                    
                }
                else
                {
                    que.Dequeue();
                }
            }
            Console.Write(string.Join(", ",que));
        }
    }
}
