﻿using System;
using System.Linq;

namespace _01ReverseStrings2
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            string reverseWord = null;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }   
            Console.WriteLine(reverseWord);
        }
    }
}
