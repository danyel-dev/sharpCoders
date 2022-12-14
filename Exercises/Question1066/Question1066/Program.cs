using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            double contPositivos = 0, contNegativos = 0, contPares = 0, contImpares = 0;

            for (int i = 0; i < 5; i++)
            {
                double n = double.Parse(Console.ReadLine());

                if (n > 0)
                {
                    contPositivos++;
                }
                else if (n < 0)
                {
                    contNegativos++;
                }
                
                if (n % 2 == 0)
                {
                    contPares++;
                }
                else
                {
                    contImpares++;
                } 
            }

            Console.WriteLine($"{contPares} valor(es) par(es)");
            Console.WriteLine($"{contImpares} valor(es) impar(es)");
            Console.WriteLine($"{contPositivos} valor(es) positivo(s)");
            Console.WriteLine($"{contNegativos} valor(es) negativo(s)");
        }
    }
}
