using System;

namespace URI
{
    class Program
    {
        static void Main()
        {
            int i;
            double valor;
            double[] cedulas = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.10, 0.05, 0.01 }, quantidadeNotas = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
          

            valor = Convert.ToDouble(Console.ReadLine());

            for(i = 0; i < cedulas.Length; i++) {
                quantidadeNotas[i] = Math.Truncate(valor / cedulas[i]);
                valor = Double.Parse((valor % cedulas[i]).ToString("f2"));
            }

            Console.WriteLine("NOTAS:");
            for(i = 0; i < cedulas.Length/2; i++) {
                Console.WriteLine($"{quantidadeNotas[i]} nota(s) de R$ {cedulas[i]:0.00}");
            }

            Console.WriteLine("MOEDAS:");
            for (i = cedulas.Length / 2; i < cedulas.Length; i++)
            {
                Console.WriteLine($"{quantidadeNotas[i]} moeda(s) de R$ {cedulas[i]:0.00}");
            }
        }
    }
}
