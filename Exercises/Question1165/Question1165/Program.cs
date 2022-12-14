using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                int countPrimos = 0;

                for (int j = 1; j <= X; j++)
                {
                    if (X % j == 0)
                    {
                        countPrimos++;
                    }

                    if (countPrimos > 2)
                    {
                        break;
                    }
                }

                if(countPrimos == 2)
                {
                    Console.WriteLine($"{X} eh primo");
                } else
                {
                    Console.WriteLine($"{X} nao eh primo");
                }
            }
        }
    }
}