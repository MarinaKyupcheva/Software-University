﻿using System;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x=>x)
                .ToArray();

            
                Console.WriteLine(string.Join(", ", numbers));
               
           
        }
    }
}
