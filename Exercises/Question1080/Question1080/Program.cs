using System;


namespace Beecrowd
{
    class Program
    {
        static void Main() 
        {
            int maior = 0, indiceMaior = 0;

            for(int i = 0; i < 100; i++)
            {
                int N = int.Parse(Console.ReadLine());
                
                if(i == 0 || N > maior)
                {
                    maior = N;
                    indiceMaior = i;
                } 
            }

            Console.WriteLine(maior);
            Console.WriteLine(indiceMaior + 1);
        }
    }
}