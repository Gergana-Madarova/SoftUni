﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int N = int.Parse(Console.ReadLine());
                sum += N;
            }
            Console.WriteLine(sum);
        }
    }
}
