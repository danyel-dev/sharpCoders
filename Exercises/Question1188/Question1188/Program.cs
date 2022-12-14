using System;


namespace Beecrowd_1188
{
    class Program
    {
        static void Main()
        {
            string operacao = Console.ReadLine();

            const int NUM = 12;
            double[,] mat = new double[NUM, NUM];

            double soma = 0.0, count = 0.0;

            if (operacao == "S")
            {
                for (int i = 0; i < NUM; i++)
                {
                    for (int j = 0; j < NUM; j++)
                    {
                        mat[i, j] = double.Parse(Console.ReadLine());

                        if (i + j > NUM - 1 && i > j)
                        {
                            soma += mat[i, j];
                        }
                    }
                }

                Console.WriteLine($"{soma:F1}");
            }
            else
            {
                for (int i = 0; i < NUM; i++)
                {
                    for (int j = 0; j < NUM; j++)
                    {
                        mat[i, j] = double.Parse(Console.ReadLine());

                        if (j > i && j < (NUM - 1 - i))
                        {
                            soma += mat[i, j];
                            count++;
                        }
                    }
                }

                double media = soma / count;
                Console.WriteLine($"{media:F1}");
            }
        }
    }
}
