using System;


namespace Beecrowd_1190
{
    class Program
    {
        static void Main()
        {
            string operacao = Console.ReadLine();
            
            const int TAM = 12;
            double[,] Mat = new double[TAM, TAM];

            double soma = 0, count = 0;

            if (operacao == "S")
            {
                for (int i = 0; i < TAM; i++)
                {
                    for (int j = 0; j < TAM; j++)
                    {
                        Mat[i, j] = double.Parse(Console.ReadLine());

                        if (j > i && j > TAM - 1 - i)
                        {
                            soma += Mat[i, j];            
                        }
                    }
                }

                Console.WriteLine($"{soma:F1}");
            }
            else
            {
                for (int i = 0; i < TAM; i++)
                {
                    for (int j = 0; j < TAM; j++)
                    {
                        Mat[i, j] = double.Parse(Console.ReadLine());

                        if (j > i && j > TAM - 1 - i)
                        {
                            soma += Mat[i, j];
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
