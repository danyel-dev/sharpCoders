using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int X, Y, soma = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
               
                X = int.Parse(line[0]);
                Y = int.Parse(line[1]);

                int maior = X, menor = Y;

                if(Y > X)
                {
                    maior = Y;
                    menor = X;
                } 

                for (int j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }

                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}
