﻿using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i}^{2} = {Math.Pow(i, 2)}");
                }
            }
        }
    }
}