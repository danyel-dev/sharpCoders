using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int contPositivos = 0;

            for(int i = 0; i < 6; i++)
            {
                double n = double.Parse(Console.ReadLine());

                if(n > 0)
                {
                    contPositivos++;
                }
            }

            Console.WriteLine($"{contPositivos} valores positivos");
        }
    }
}
