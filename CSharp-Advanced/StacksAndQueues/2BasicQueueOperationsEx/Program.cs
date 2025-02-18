﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _2BasicQueueOperationsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(input[i]);
            }
            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(x))
            {
                Console.WriteLine($"true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine(0);
            }

            else if(!numbers.Contains(x))
            {
                Console.WriteLine(numbers.Min());
            }

            
        }
    }
}
