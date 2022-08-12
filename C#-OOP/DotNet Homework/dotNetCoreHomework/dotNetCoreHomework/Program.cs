using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace dotNetCoreHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var list2 = new CustomList<int>() {1,3, 2,4,4, 4, 5, 6};
            //list2.Randomize();
            //list2.RemoveDuplicates();

            //var words = new List<string>() {"oreo", "noe", "my", "cool"};
            //if (words.Any(x=>x.Contains('e')))
            //{
            //    var filteredWords = words.Where(x => x.Contains('e')).OrderBy(x => x).ToList();
            //    var lastWord = filteredWords[^1];
            //    Console.WriteLine($"The last word is {lastWord}");
            //}
            //else
            //{
            //    Console.WriteLine("No words");
            //}
            var list=new List<int>(){1,2,3,4,5,6,-3,-4,10};
            Box box=new Box(list);
           var result= box.Filter(x => x%2==0 || x%5==0 || x%10==0);

            //var list = new CustomCollection<int>
            //{
            //    1,
            //    2,
            //    3,
            //    4,
            //    5
            //};
            //var randomArr=list.Randomize();
            //foreach (var i in randomArr)
            //{
            //    Console.Write($"{i} ");
            //}
        }
    }
}
