using System;


namespace Beecrowd1435
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                int N = int.Parse(Console.ReadLine());

                if(N == 0)
                {
                    break;
                }

                int[,] M = new int[N , N];
                int aux = N - 1, count = 1;

                for(int k = 0; k <= N; k++)
                {    
                    for(int i = 0; i < N; i++)
                    {
                        for(int j = 0; j < N; j++)
                        {
                            if(i >= k && i <= aux && j >= k && j <= aux)
                            {
                                M[i, j] = count;
                            }
                        }
                    }

                    count++;
                    aux--;
                }

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if(j == N - 1)
                        {
                            Console.Write(string.Format("{0, 3}", M[i, j]));
                        }
                        else
                        {
                            Console.Write(string.Format("{0, 3}", M[i, j]) + " ");
                        }
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
