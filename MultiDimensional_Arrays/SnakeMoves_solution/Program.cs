using System;
using System.Collections.Generic;
using System.Linq;


namespace SnakeMoves_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            Queue<string> snake = new Queue<string>();
            for (int i = 0; i < input.Length; i++)
            {
                snake.Enqueue(input[i].ToString());
            }

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < dimensions[0]; row++)
            {
                if (row%2==0)
                {
                    for (int col = 0; col < dimensions[1]; col++)
                    {
                        snake.Enqueue(snake.Peek());
                        matrix[row, col] = snake.Dequeue();
                    }
                }else
                {
                    for (int col = dimensions[1]-1; col >=0; col--)
                    {
                        snake.Enqueue(snake.Peek());
                        matrix[row, col] = snake.Dequeue();
                    }
                }
                
            }


            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int k = 0; k < dimensions[1]; k++)
                {
                    Console.Write(matrix[i,k]);
                }
                Console.WriteLine();
            }
        }
    }
}
