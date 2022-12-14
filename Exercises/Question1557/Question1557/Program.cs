using System;
using System.Globalization;

namespace Beecrowd_1557
{
    class Program
    {
        static void Main()
        {

            while(true) {
                int N = int.Parse(Console.ReadLine());  
                
                if (N == 0) break;

                int[,] M = new int[N, N];

                int maior = (int)Math.Pow(2, N - 1);
                maior = maior * maior;

                int T = maior.ToString().Length;

                int i, j, aux = 1, count = 1;

                for(i = 0; i < N; i++)
                {
                    for(j = 0; j < N; j++)
                    {
                        M[i, j] = aux;
                        aux *= 2;

                        if(j == N -1)
                            Console.Write(M[i, j].ToString().PadLeft(T));
                        else
                            Console.Write(M[i, j].ToString().PadLeft(T) + " ");
                    }

                    Console.WriteLine();

                    count = count * 2;
                    aux = count;
                }
                
                Console.WriteLine();
            }
        }
    }
}
