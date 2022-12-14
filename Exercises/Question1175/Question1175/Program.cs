using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = 20;
            int[] vet = new int[N];

            for(int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(vet);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"N[{i}] = {vet[i]}");
            }
        }
    }
}
