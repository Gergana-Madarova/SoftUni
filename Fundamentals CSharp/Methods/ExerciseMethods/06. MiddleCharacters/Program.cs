﻿using System;

namespace _06._MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetMiddleCharacters(input);
        }

        private static void GetMiddleCharacters(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[(input.Length / 2) - 1]}{input[input.Length / 2]}");
            }
            else if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
        }
    }
}
