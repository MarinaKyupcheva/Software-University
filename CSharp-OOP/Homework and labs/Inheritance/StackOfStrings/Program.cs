﻿using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            Console.WriteLine(stack.IsEmpty());

            stack.AddRange(new List<string>()
            {
                "Fifo",
                "Pipi",
                "1111",
                "0000"

            });
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
