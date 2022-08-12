using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace dotNetCoreHomework
{
    public class CustomList<T>:List<T>
    {
        private IEnumerable<T> List => this.ToList();

        public List<T> Randomize()
        {
            var rnd = new Random();
            var myRandomArray = List.OrderBy(x => rnd.Next()).ToList();
            Print(myRandomArray);
            return myRandomArray;
        }

        public List<T> RemoveDuplicates()
        {
            var noDuplicates=new HashSet<T>(List).ToList();
            Print(noDuplicates);
            return noDuplicates;
        }

        private static void Print(IEnumerable<T> arr)
        {
            foreach (var i in arr)
            {
                Console.Write($"{{{i}}} ");
            }

            Console.WriteLine();
        }
    }
}