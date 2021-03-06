﻿using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumOdd = 0.0;
            double sumEven = 0.0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;


            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    sumOdd += number;
                    if (number >= maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number <= minOdd)
                    {
                        minOdd = number;
                    }
                }
                else
                {
                    sumEven += number;
                    if (number >= maxEven)
                    {
                        maxEven = number;
                    }
                    if (number <= minEven)
                    {
                        minEven = number;
                    }
                }

            }

            Console.WriteLine($"OddSum={sumOdd:f2},");
            if (minOdd != double.MaxValue)
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
            }
            if (maxOdd != double.MinValue)
            {
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={sumEven:f2},");
            if (minEven != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={minEven:f2},");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }
            if (maxEven != double.MinValue)
            {
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
