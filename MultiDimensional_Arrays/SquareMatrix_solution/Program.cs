using System;
using System.Linq;

namespace SquareMatrix_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            int br = 0;
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int u = 0; u < matrix.GetLength(1); u++)
                {
                    matrix[i, u] = row[u];
                }
            }
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int u = 0; u < matrix.GetLength(1)-1; u++)
                {
                    if (   matrix[i,u] == matrix[i,u+1]
                        && matrix[i,u] == matrix[i+1,u]
                        && matrix[i,u] == matrix[i+1,u+1])
                    {
                        br++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(br);

        }

    }
}
