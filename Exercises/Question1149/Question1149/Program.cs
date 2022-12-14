using System;

namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');

            int A = int.Parse(line[0]);
            int N = 0, flag = 0;

            for(int i = 1; i < line.Length; i++)
            {
                if (int.Parse(line[i]) > 0 && flag == 0)
                {
                    N = int.Parse(line[i]);
                    flag = 1;
                }    
            }

            int aux = 0;

            for(int i = N; i > 0; i--)
            {
                aux += A + i - 1;
            }

            Console.WriteLine(aux);
        }
    }
}