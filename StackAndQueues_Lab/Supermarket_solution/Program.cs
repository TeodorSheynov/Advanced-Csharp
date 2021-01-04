using System;
using System.Collections.Generic;

namespace Supermarket_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = new Queue<string>();
            string clientAdd = Console.ReadLine();
            while (clientAdd!="End")
            {
                if (clientAdd=="Paid")
                {
                    foreach (var item in clients)
                    {
                        Console.WriteLine(item);
                    }
                    clients.Clear();
                }else
                {
                    clients.Enqueue(clientAdd);

                }
                clientAdd = Console.ReadLine();
            }
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
