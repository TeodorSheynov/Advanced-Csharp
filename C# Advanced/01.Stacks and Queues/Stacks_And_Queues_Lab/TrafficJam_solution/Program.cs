using System;
using System.Collections.Generic;

namespace TrafficJam_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCanPass = int.Parse(Console.ReadLine());
            string cars = Console.ReadLine();
            int br = 0;
            Queue<string> carsInQue = new Queue<string>();
            while (cars != "end")
            {
                if (cars == "green")
                {
                    if (carsCanPass>carsInQue.Count)
                    {
                        while (carsInQue.Count!=0)
                        {
                            Console.WriteLine($"{carsInQue.Dequeue()} passed!");
                            br++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < carsCanPass; i++)
                        {
                            Console.WriteLine($"{carsInQue.Dequeue()} passed!");
                            br++;
                        }
                    }
                }
                else
                {
                    carsInQue.Enqueue(cars);
                }
                cars = Console.ReadLine();
            }
            Console.WriteLine($"{br} cars passed the crossroads.");

        }
    }
}
