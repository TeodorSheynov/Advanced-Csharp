using System;
using System.Collections.Generic;

namespace SongsQueue_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> que = new Queue<string>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));
            string song = string.Empty;
            
            while (que.Count>0)
            {
                string fullCOmand = Console.ReadLine();
                if (fullCOmand.StartsWith("Add"))
                {
                    
                    song = fullCOmand.Substring(4);
                    fullCOmand = "Add";
                }
                
                switch (fullCOmand)
                {
                    case "Play":
                        que.Dequeue();
                        break;
                    case "Add":
                        
                        if (que.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }else
                        {
                            que.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",que));
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine("No more songs!");
            
        }
    }
}
