using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());  

            for(int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                int X = int.Parse(line[0]);
                int Y = int.Parse(line[1]);

                int count = 0, soma = 0;

                while(count < Y)
                {
                    if(X % 2 != 0)
                    {
                        soma += X;
                        count++;
                    }
                    X++;
                }

                Console.WriteLine(soma);
            }
        }
    }
}