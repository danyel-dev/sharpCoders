using System;


namespace Beecrowd
{
    class Program
    {
        static void Main() 
        {
            int N = int.Parse(Console.ReadLine());
            double valor1, valor2, valor3, mediaPonderada;

            for(int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                
                valor1 = double.Parse(line[0]);
                valor2 = double.Parse(line[1]);
                valor3 = double.Parse(line[2]);

                mediaPonderada = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;
                Console.WriteLine($"{mediaPonderada:F1}");
            }
        }
    }
}