using System;
using System.Linq;

namespace JaggedArrayManipulation_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagArr = new double[n][];

            for (int row = 0; row < n; row++)
            {
                    jagArr[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }
            for (int row = 0; row < n-1; row++)
            {
                if (jagArr[row].Length == jagArr[row + 1].Length)
                {
                    for (int col = 0; col < jagArr[row].Length; col++)
                    {
                        jagArr[row][col] *= 2;
                    }
                    for (int col = 0; col < jagArr[row+1].Length; col++)
                    {
                        jagArr[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagArr[row].Length; col++)
                    {
                        jagArr[row][col] /= 2;
                    }
                    for (int col = 0; col < jagArr[row+1].Length; col++)
                    {
                        jagArr[row+1][col] /= 2;
                    }

                }
            }

            // Commands 
            string[] commands = Console.ReadLine().Split();
            while (commands[0]!="End")
            {
                int x = int.Parse(commands[1]);
                int y = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                switch (commands[0])
                {
                    case "Add":
                        if (x>n||x<0 || jagArr[x].Length<y||y<0)
                        {
                            break;
                        }else
                        {
                            jagArr[x][y] += value;
                        }
                        break;
                    case "Subtract":
                        if (x > n||x<0 || jagArr[x].Length < y||y<0)
                        {
                            break;
                        }
                        else
                        {
                            jagArr[x][y] -= value;
                        }
                        break;
                    default:
                        break;
                }
                commands = Console.ReadLine().Split();
            }


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < jagArr[row].Length; col++)
                {
                    Console.Write(jagArr[row][col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}





