using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            long fieldSize = int.Parse(Console.ReadLine());
            
             

            
            string[] commands = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            string[,] matrix = InitializeMatrix(fieldSize);
            Queue<string> player1Comands = new Queue<string>();
            Queue<string> player2Comands = new Queue<string>();
            bool comand1 = true;
            bool comand2 = true;

            for (int i = 0; i < commands.Length; i++)
            {
                if (i % 2 == 0)
                {
                    player1Comands.Enqueue(commands[i]);

                }
                else
                {
                    player2Comands.Enqueue(commands[i]);
                }
            }
            int player1Ships = ShipCount(matrix, "<");
            int player2Ships = ShipCount(matrix, ">");
            int totalShips = player1Ships + player2Ships;
            while (player1Ships != 0 && player2Ships != 0)
            {
                if (comand1)
                {
                    if (player1Comands.Count != 0)
                    {
                        int[] cordinates1 = player1Comands.Dequeue().Split(" ").Select(int.Parse).ToArray();
                        int x1 = cordinates1[0];
                        int y1 = cordinates1[1];
                        if (IsInRange(x1, y1, fieldSize))
                        {
                            if (matrix[x1, y1] == "#")
                            {
                                matrix[x1, y1] = "X";
                                IfIsMine(x1, y1, fieldSize, player1Ships, player2Ships, matrix);
                            }
                            else if (matrix[x1, y1] == ">")
                            {
                                matrix[x1, y1] = "X";
                                player2Ships--;
                            }

                        }
                    }
                    else
                    {
                        comand1 = false;
                    }

                }
                player1Ships= ShipCount(matrix, "<");
                if (player2Ships == 0)
                {
                    Console.WriteLine($"Player One has won the game! {totalShips - player1Ships} ships have been sunk in the battle.");
                    return;
                }
                if (comand2)
                {

                    if (player2Comands.Count != 0)
                    {
                        int[] cordinates2 = player2Comands.Dequeue().Split(" ").Select(int.Parse).ToArray();
                        int x2 = cordinates2[0];
                        int y2 = cordinates2[1];
                        if (IsInRange(x2, y2, fieldSize))
                        {
                            if (matrix[x2, y2] == "#")
                            {
                                matrix[x2, y2] = "X";
                                IfIsMine(x2, y2, fieldSize, player1Ships, player2Ships, matrix);
                            }
                            else if (matrix[x2, y2] == "<")
                            {
                                matrix[x2, y2] = "X";
                                player1Ships--;
                            }

                        }
                    }else
                    {
                        comand2 = false;
                    }

                }
                player2Ships = ShipCount(matrix, ">");
                if (player1Ships == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {totalShips - player2Ships} ships have been sunk in the battle.");
                    return;
                    
                }
                if (!comand1 && !comand2)
                {
                    Console.WriteLine($"It's a draw! Player One has {player1Ships} ships left. Player Two has {player2Ships} ships left.");
                    return;
                    
                }

            }
            
                    

            
        }
        private static void Print(string[,] matrix)
        {
            for (int x = 0; x < matrix.GetLongLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLongLength(1); y++)
                {
                    Console.Write(matrix[x, y]);
                }
                Console.WriteLine();
            }
            
        }
        public static void IfIsMine(int x1, int y1, long fieldSize, int player1Ships, int player2Ships, string[,] matrix)
        {
            if (IsInRange(x1 - 1, y1, fieldSize))
            {
                MineExplode(x1 - 1, y1, matrix, player1Ships, player2Ships);
            }
            if (IsInRange(x1 + 1, y1, fieldSize))
            {
                MineExplode(x1 + 1, y1, matrix, player1Ships, player2Ships);
            }
            if (IsInRange(x1 + 1, y1 + 1, fieldSize))
            {
                MineExplode(x1 + 1, y1 + 1, matrix, player1Ships, player2Ships);
            }
            if (IsInRange(x1, y1 - 1, fieldSize))
            {
                MineExplode(x1, y1 - 1, matrix, player1Ships, player2Ships);
            }
            if (IsInRange(x1, y1 + 1, fieldSize))
            {
                MineExplode(x1, y1 + 1, matrix, player1Ships, player2Ships);
            }
            if (IsInRange(x1 - 1, y1 - 1, fieldSize))
            {
                MineExplode(x1 - 1, y1 - 1, matrix, player1Ships, player2Ships);
            }
            if (IsInRange(x1 - 1, y1 + 1, fieldSize))
            {
                MineExplode(x1 - 1, y1 + 1, matrix, player1Ships, player2Ships);
            }
            if (IsInRange(x1 + 1, y1 - 1, fieldSize))
            {
                MineExplode(x1 + 1, y1 - 1, matrix, player1Ships, player2Ships);
            }
        }

        public static void MineExplode(int x1, int y1, string[,] matrix, int player1Ships, int player2Ships)
        {
            if (matrix[x1, y1] == "<")
            {
                player1Ships--;
                matrix[x1, y1] = "X";
            }
            if (matrix[x1, y1] == ">")
            {
                player2Ships--;
                matrix[x1, y1] = "X";
            }
            
        }

        public static bool IsInRange(int x, int y, long row)
        {
            if (x < 0 || y < 0 || x >= row || y >= row)
            {
                return false;
            }
            return true;

        }
        public static int ShipCount(string[,] matrix, string elemtToFind)
        {
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int t = 0; t < matrix.GetLength(1); t++)
                {
                    if (matrix[i, t] == elemtToFind)
                    {
                        count++;
                    }
                }

            }


            return count;


        }
        public static string[,] InitializeMatrix(long n)
        {
            string[,] arr = new string[n, n];
            for (int x = 0; x < n; x++)
            {
                string[] row = Console.ReadLine().Split(" ").ToArray();
                for (int y = 0; y < row.Length; y++)
                {
                    arr[x, y] = row[y];
                }
            }
            return arr;
        }
    }
}
