using System;
using System.Linq;

namespace ReversedAndExclude_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Func<int, bool> divisible = x => x % n != 0;
            var reversedArr = arr.Reverse().Where(divisible);
            Console.WriteLine(string.Join(" ",reversedArr));
        }  
    }
}
