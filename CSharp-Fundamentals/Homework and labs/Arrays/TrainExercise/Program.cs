﻿using System;

namespace TrainExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];

            int sum = 0;
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }
            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(sum);
        }
    }
}
