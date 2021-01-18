using System;
using System.Linq;

namespace MatrixShuffling_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < dimensions[0]; row++)
            {
                string[] rowInput= Console.ReadLine().Split();
                for (int col = 0; col <dimensions[1]; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
            string[] commands= Console.ReadLine().Split();
            while (commands[0]!="END")
            {
                if (commands.Length==5)
                {

                    if (commands[0] == "swap")
                    {
                        int x1 = int.Parse(commands[1]);
                        int y1 = int.Parse(commands[2]);
                        int x2 = int.Parse(commands[3]);
                        int y2 = int.Parse(commands[4]);
                        if (x1<dimensions[0]&&x2<dimensions[0]&&y1<dimensions[1]&&y2<dimensions[1])
                        {
                            string temporary;
                            temporary = matrix[x1, y1];
                            matrix[x1, y1] = matrix[x2, y2];
                            matrix[x2, y2] = temporary;
                            for (int row = 0; row < dimensions[0]; row++)
                            {
                                for (int icol = 0; icol < dimensions[1]; icol++)
                                {
                                    Console.Write(matrix[row,icol]+" ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    
                }

                commands = Console.ReadLine().Split();
            }
        }
    }
}
