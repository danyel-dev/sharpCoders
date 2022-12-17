using System;
using System.Collections.Generic;


namespace Beecrowd_2407
{
    class Program
    {
        static int quadradoMagico(int[,] M, int N)
        {
            int somaLinhas = 0, somaDiagonalPrincipal = 0;
            int[] somaColunas = new int[N];

            int sum = N * (N * N + 1) / 2;

            for (int i = 0; i < N; i++) {
                string[] line = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {
                    M[i, j] = int.Parse(line[j]);

                    somaLinhas += M[i, j];
                    somaColunas[j] += M[i, j];

                    if (i == j)
                        somaDiagonalPrincipal += M[i, j];
                }

                if (somaLinhas != sum) return 0;

                somaLinhas = 0;
            }

            for (int i = 0; i < N; i++) 
                if (somaColunas[i] != sum) return 0;

            if (somaDiagonalPrincipal != sum) 
                return 0;
            
            return sum;
        }

        static void Main() {
            int N = int.Parse(Console.ReadLine());

            int[,] M = new int[N, N];

            Console.WriteLine(quadradoMagico(M, N));
        }
    }
}
