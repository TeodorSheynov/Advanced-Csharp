using System;
using System.Linq;

namespace CustomeMinFunction_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> smallest = TheSmallest;
            Console.WriteLine(smallest(arr));
        }

        private static int TheSmallest(int[] p)
        {
            int minValue=p[0];
            foreach (var item in p)
            {
                if (minValue>item)
                {
                    minValue = item;
                }
            }
            return minValue;
        }
    }
}
