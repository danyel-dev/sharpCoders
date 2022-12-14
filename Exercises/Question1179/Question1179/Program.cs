using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int[] vetPar = new int[5];
            int[] vetImpar = new int[5];

            int countPar = 0, countImpar = 0;

            for (int i = 0; i < 15; i++)
            {
                int N = int.Parse(Console.ReadLine());

                if(N % 2 == 0)
                {
                    vetPar[countPar] = N;
                    countPar++;

                    if(countPar == 5)
                    {
                        for(int j = 0; j < 5; j++)
                        {
                            Console.WriteLine($"par[{j}] = {vetPar[j]}");
                        }

                        countPar = 0;
                    }

                } else
                {
                    vetImpar[countImpar] = N;
                    countImpar++;

                    if (countImpar == 5)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine($"impar[{j}] = {vetImpar[j]}");
                        }

                        countImpar = 0;
                    }

                }
            }

            for(int i = 0; i < countImpar; i++)
            {
                Console.WriteLine($"impar[{i}] = {vetImpar[i]}");
            }

            for (int i = 0; i < countPar; i++)
            {
                Console.WriteLine($"par[{i}] = {vetPar[i]}");
            }
        }
    }
}
