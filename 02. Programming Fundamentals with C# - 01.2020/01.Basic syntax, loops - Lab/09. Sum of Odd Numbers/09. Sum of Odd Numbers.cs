﻿using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = 1;  ; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    counter++;
                    if (counter == n)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
