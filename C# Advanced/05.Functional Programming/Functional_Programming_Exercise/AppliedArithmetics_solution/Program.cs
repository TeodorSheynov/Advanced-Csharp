using System;
using System.Linq;

namespace AppliedArithmetics_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command!="end")
            {
                switch (command)
                {
                    case "add":
                        arr = Arithmetic(arr, x => x += 1);
                        break;
                    case "multiply":
                        arr = Arithmetic(arr, x => x *= 2);
                        break;
                    case "subtract":
                        arr = Arithmetic(arr, x => x -= 1);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ",arr));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            
        }

        private static int[] Arithmetic(int[] x,Func<int,int> operatin)
        {
            x = x.Select(operatin)
                .ToArray();
            return x;
            
        }
    }
}
