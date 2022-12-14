using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for(int i = 0; i < T; i++)
            {
                Int64 ant = 0, atual = 1, prox = 1;

                Int64 N = Convert.ToInt64(Console.ReadLine());

                for(int j = 0; j <= N; j++)
                {
                    if(j == N)
                    {
                        break;
                    }
                    ant = atual;
                    atual = prox;
                    prox = ant + atual;
                }

                Console.WriteLine($"Fib({N}) = {ant}");
            }

        }
    }
}
