using System;

namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int ant = 0, atual = 1, prox = 1;

            for(int i = 0; i < N - 1; i++)
            {
                Console.Write(ant + " ");
                ant = atual;
                atual = prox;
                prox = ant + atual;
            }

            Console.WriteLine(ant);
        }
    }
}
