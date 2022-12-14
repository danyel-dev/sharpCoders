using System;


namespace Beecrowd_1183
{
    class Program
    {
        static void Main()
        {
            double[,] mat = new double[12, 12];
            
            string operacao = Console.ReadLine().ToUpper();

            double soma = 0; 
            int count = 0;

            if(operacao == "S")
            {
                for(int i = 0; i < 12; i++)
                {
                    for(int j = 0; j < 12; j++)
                    {
                        mat[i, j] = double.Parse(Console.ReadLine());
                    
                        if (j > i)
                        {
                            soma += mat[i, j];
                        }
                    }
                }

                Console.WriteLine($"{soma:F1}");
            } else
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        mat[i, j] = double.Parse(Console.ReadLine());

                        if (j > i)
                        {
                            soma += mat[i, j];

                            count++;
                        }
                    }
                }

                double media = (double)soma / count;
                Console.WriteLine($"{media:F1}");
            }
        }
    }
}
