using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = 12;
            double[,] mat = new double[N, N];

            int coluna = int.Parse(Console.ReadLine());
            string operacao = Console.ReadLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double soma = 0, media = 0;

            for (int i = 0; i < N; i++)
            {
                soma += mat[i, coluna];
            }

            if (operacao == "S")
            {
                Console.WriteLine($"{soma:F1}");
            }
            else
            {
                media = (double)soma / N;
                Console.WriteLine($"{media:F1}");
            }
        }
    }
}
