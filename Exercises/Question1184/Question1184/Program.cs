﻿using System;


namespace Beecrowd_1183
{
    class Program
    {
        static void Main()
        {
            char operacao = char.Parse(Console.ReadLine());

            int NUM = 12;
            double[,] mat = new double[NUM, NUM];

            double soma = 0;
            double count = 0;

            for (int i = 0; i < NUM; i++)
            {
                for (int j = 0; j < NUM; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine());

                    if (i > j)
                    {
                        soma += mat[i, j];
                        count++;
                    }
                }
            }  

            
            if(operacao == 'S')
            {
                Console.WriteLine($"{soma:F1}");
            } else
            {
                double media = (double)soma / count;
                Console.WriteLine($"{media:F1}");
            }
        }
    }
}