using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake_solution
{
    class Program
    {

        static void Main(string[] args)
        {
            int matrixDimensions = int.Parse(Console.ReadLine());

            char[,] matrix = InitializeMatrix(matrixDimensions);
            int[] snakeCordinates = FindCordinates(matrix, 'S');
            int[] burrows = FindCordinates(matrix, 'B');



            int money = 0;
            bool inOut = true;


            do
            {
                string comand = Console.ReadLine();
                int row = snakeCordinates[0];
                int col = snakeCordinates[1];
                switch (comand)
                {
                    case "up":

                        if (IsInRange(row - 1, col, matrixDimensions))
                        {
                            if (matrix[row - 1, col] == '*')
                            {
                                money ++;
                                matrix[row, col] = '.';
                                matrix[--row, col] = 'S';
                                snakeCordinates[0] = row;
                                snakeCordinates[1] = col;
                            }
                            else if (char.IsLetter(matrix[row - 1, col]))
                            {
                                matrix[row, col] = '.';
                                snakeCordinates = Pillars(row - 1, col, burrows, matrix);
                            }
                            else
                            {
                                matrix[row, col] = '.';
                                matrix[--row, col] = 'S';
                                snakeCordinates[0] = row;
                                snakeCordinates[1] = col;
                            }
                        }
                        else
                        {
                            matrix[row, col] = '.';
                            inOut = false;
                        }
                        break;
                    case "down":
                        if (IsInRange(row + 1, col, matrixDimensions))
                        {
                            if (matrix[row + 1, col] == '*')
                            {
                                money ++;
                                matrix[row, col] = '.';
                                matrix[++row, col] = 'S';
                                snakeCordinates[0] = row;
                                snakeCordinates[1] = col;
                            }
                            else if (char.IsLetter(matrix[row + 1, col]))
                            {
                                matrix[row, col] = '.';
                                snakeCordinates = Pillars(row + 1, col, burrows, matrix);
                            }
                            else
                            {
                                matrix[row, col] = '.';
                                matrix[++row, col] = 'S';
                                snakeCordinates[0] = row;
                                snakeCordinates[1] = col;
                            }
                        }
                        else
                        {
                            matrix[row, col] = '.';
                            inOut = false;
                        }
                        break;
                    case "left":
                        if (IsInRange(row, col - 1, matrixDimensions))
                        {
                            if (matrix[row, col - 1]=='*')
                            {
                                money ++;
                                matrix[row, col] = '.';
                                matrix[row, --col] = 'S';
                                snakeCordinates[0] = row;
                                snakeCordinates[1] = col;
                            }
                            else if (char.IsLetter(matrix[row, col - 1]))
                            {
                                matrix[row, col] = '.';
                                snakeCordinates = Pillars(row, col - 1, burrows, matrix);
                            }
                            else
                            {
                                matrix[row, col] = '.';
                                matrix[row, --col] = 'S';
                                snakeCordinates[0] = row;
                                snakeCordinates[1] = col;
                            }
                        }
                        else
                        {
                            matrix[row, col] = '.';
                            inOut = false;
                        }
                        break;
                    case "right":
                        if (IsInRange(row, col + 1, matrixDimensions))
                        {
                            if (matrix[row, col + 1]=='*')
                            {
                                money ++;
                                matrix[row, col] = '.';
                                matrix[row, ++col] = 'S';
                                snakeCordinates[0] = row;
                                snakeCordinates[1] = col;
                            }
                            else if (char.IsLetter(matrix[row, col + 1]))
                            {
                                matrix[row, col] = '.';
                                snakeCordinates = Pillars(row, col + 1, burrows, matrix);
                            }
                            else
                            {
                                matrix[row, col] = '.';
                                matrix[row, ++col] = 'S';
                                snakeCordinates[0] = row;
                                snakeCordinates[1] = col;
                            }
                        }
                        else
                        {
                            matrix[row, col] = '.';
                            inOut = false;
                        }
                        break;
                    default:
                        break;
                }
            } while (money < 10 && inOut);
            if (money >= 10)
            {
                Console.WriteLine($"You won! You fed the snake.");
                Console.WriteLine($"Food eaten: {money}");
            }
            if (!inOut)
            {
                Console.WriteLine($"Game over!");
                Console.WriteLine($"Food eaten: {money}");
            }
            Print(matrix);
        }

        public static int[] Pillars(int row, int col, int[] pilars, char[,] matrix)
        {
            List<int> newCords = new List<int>();
            if (row == pilars[0] && col == pilars[1])
            {

                matrix[pilars[0], pilars[1]] = '.';
                matrix[pilars[2], pilars[3]] = 'S';

                newCords.Add(pilars[2]);
                newCords.Add(pilars[3]);
                pilars = null;
                return newCords.ToArray();
            }
            else if (row == pilars[2] && col == pilars[3])
            {

                matrix[pilars[2], pilars[3]] = '.';
                matrix[pilars[0], pilars[1]] = 'S';
                newCords.Add(pilars[0]);
                newCords.Add(pilars[1]);
                pilars = null;
                return newCords.ToArray();
            }
            return null;
        }

        private static void Print(char[,] matrix)
        {
            for (int x = 0; x < matrix.GetLongLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLongLength(1); y++)
                {
                    Console.Write(matrix[x, y]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }
        private static bool IsInRange(int x, int y, int row)
        {
            if (x < 0 || y < 0 || x >= row || y >= row)
            {
                return false;
            }
            return true;

        }

        public static char[,] InitializeMatrix(int n)
        {
            char[,] arr = new char[n, n];
            for (int x = 0; x < n; x++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                for (int y = 0; y < row.Length; y++)
                {
                    arr[x, y] = row[y];
                }
            }
            return arr;
        }
        public static int[] FindCordinates(char[,] matrix, char elemtToFind)
        {
            if (elemtToFind == 'B')
            {
                List<int> pillarCords = new List<int>();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int t = 0; t < matrix.GetLength(1); t++)
                    {
                        if (matrix[i, t] == elemtToFind)
                        {
                            pillarCords.Add(i);
                            pillarCords.Add(t);
                        }
                    }

                }
                if (pillarCords.Count == 4)
                {
                    return pillarCords.ToArray();
                }
                else
                {
                    return null;
                }

            }
            else
            {
                int[] cords = new int[2];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int t = 0; t < matrix.GetLength(1); t++)
                    {
                        if (matrix[i, t] == elemtToFind)
                        {
                            cords[0] = i;
                            cords[1] = t;
                            return cords;
                        }
                    }

                }

            }
            return null;


        }
    }
}
