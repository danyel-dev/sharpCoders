﻿using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());  

            for(int i = 1; i <= X; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
