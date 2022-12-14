using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            int aux = 0;

            int[] N = new int[1000];

            for(int i = 0; i < 1000; i++)
            {
                N[i] = aux;
                aux++;
                
                if(aux == T)
                {
                    aux = 0;
                }
            }
            
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"N[{i}] = {N[i]}");
            }
        }
    }
}
