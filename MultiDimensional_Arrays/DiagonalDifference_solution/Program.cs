using System;
using System.Linq;

namespace DiagonalDifference_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] x = new int[n, n];
            for (int i = 0; i <x.GetLength(0) ; i++)
            {
               int[] arr= Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int y = 0; y < x.GetLength(1); y++)
                {
                    x[i, y] = arr[y];
                }
            }
            int sum1= 0;
            int z = x.GetLength(1)-1;
            int sum2 = 0;
            for (int i = 0; i < x.GetLength(1); i++)
            {
                sum1 += x[i, i];
                sum2 += x[i, z];
                z--;
                
            }
            
            Console.WriteLine(Math.Abs(sum1-sum2));
            
        }
    }
}
