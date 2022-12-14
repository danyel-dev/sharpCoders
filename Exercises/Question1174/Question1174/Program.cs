using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = 100;
            double[] vet = new double[N];

            for(int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            for(int i = 0; i < N; i++)
            {
                if (vet[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {vet[i]:F1}");
                }
            }
        }
    }
}
