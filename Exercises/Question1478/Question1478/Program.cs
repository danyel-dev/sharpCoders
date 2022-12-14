using System;


namespace Beecrowd_1478
{
    class Program
    {
        static void Main()
        {
            while(true) {
                int N = int.Parse(Console.ReadLine());

                if (N == 0)
                    break;

                int[,] M = new int[N, N];

                int aux;

                for(int i = 0; i < N; i++) {
                    aux = i + 1;

                    for(int j = 0; j < N; j++) {
                        if (j != 0) {
                            if (i == j)
                                aux = 1;
                            else if (j > i)
                                aux++;
                            else
                                aux--;
                        }

                        M[i, j] = aux;
                    }
                }

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j == N - 1)
                            Console.Write(string.Format("{0, 3}", M[i, j]));
                        else
                            Console.Write(string.Format("{0, 3}", M[i, j]) + " ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
