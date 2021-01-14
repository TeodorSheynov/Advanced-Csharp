using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> que = new Queue<int>();

            bool tour = false;
            int fuel = 0;
            int distance = 0;
            int index = 0;
            int[] arr = new int[2];
            for (int k = 0; k < n; k++)
            {
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                que.Enqueue(arr[0]);
                que.Enqueue(arr[1]);
            }
            Queue<int> q = new Queue<int>(que.ToArray());

            while (!tour)
            {
                for (int i = 0; i < n; i++)
                {
                    tour = true;
                    for (int k = 0; k < n; k++)
                    {
                        que.Enqueue(que.Peek());
                        fuel += que.Dequeue();
                        que.Enqueue(que.Peek());
                        distance = que.Dequeue();
                        if (fuel-distance>=0)
                        {
                            fuel -= distance;
                            
                        }else
                        {
                            fuel = 0;
                            tour = false;
                            break;
                        }
                    }
                    if (tour==false)
                    {
                        index++;
                        que = new Queue<int>(q.ToArray());
                        que.Enqueue(que.Dequeue());
                        que.Enqueue(que.Dequeue());
                        q = new Queue<int>(que.ToArray());

                    }else
                    {
                        break;
                    }
                }
                tour = true;
            }
            Console.WriteLine(index);
        }
    }
}
