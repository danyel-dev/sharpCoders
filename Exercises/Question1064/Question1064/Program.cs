using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            double contPositivos = 0, somaPositivos = 0, mediaPositivos = 0;

            for (int i = 0; i < 6; i++)
            {
                double n = double.Parse(Console.ReadLine());

                if (n > 0)
                {
                    contPositivos++;
                    somaPositivos += n;
                }
            }

            mediaPositivos = somaPositivos / contPositivos;

            Console.WriteLine($"{contPositivos} valores positivos");
            Console.WriteLine($"{mediaPositivos:F1}");
        }
    }
}
