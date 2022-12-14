using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] X = new int[N];

            int menor = 0, pos = 0;

            string[] line = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(line[i]);

                if (i == 0 || X[i] < menor)
                {
                    menor = X[i];
                    pos = i;
                }
            }

            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Posicao: {pos}");
        }
    }
}