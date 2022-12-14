using System;

namespace URI
{
    class Program
    {
        static void Main()
        {
            int valor, indice=0;
            int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 }, quantidadeNotas = { 0, 0, 0, 0, 0, 0, 0 };  

            valor = int.Parse(Console.ReadLine());
            Console.WriteLine(valor);
            
            while(valor > 0) {
                if (valor >= cedulas[indice]) {
                    quantidadeNotas[indice] = valor / cedulas[indice];
                    valor %= cedulas[indice];
                }
                indice++;
            }

            for (int i = 0; i < cedulas.Length; i++) {
                Console.WriteLine($"{quantidadeNotas[i]} nota(s) de R$ {cedulas[i]},00");
            }
        }
    }
}
