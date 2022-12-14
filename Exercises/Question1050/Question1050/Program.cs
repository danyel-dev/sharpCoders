using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int[] ddd = { 61, 71, 11, 21, 32, 19, 27, 31 };
            string[] destination = { "Brasilia", "Salvador", "Sao Paulo", "Rio de Janeiro", "Juiz de Fora", "Campinas", "Vitoria", "Belo Horizonte" };
            int flag = 0;

            int numDDD = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < ddd.Length; i++)
            {
                if (ddd[i] == numDDD)
                {
                    Console.WriteLine(destination[i]);
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("DDD nao cadastrado");  
            }
        }
    }
}
