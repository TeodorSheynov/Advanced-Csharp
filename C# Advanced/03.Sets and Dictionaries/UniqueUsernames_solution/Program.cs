﻿using System;
using System.Collections.Generic;

namespace UniqueUsernames_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}