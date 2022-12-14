using System;


namespace URI
{
    class Program
    {
        static void Main()
        {
            double[] precos = { 4.00, 4.50, 5.00, 2.00, 1.50 };
            int codigoItem, quantidadeItem;

            string[] line = Console.ReadLine().Split(' ');

            codigoItem = int.Parse(line[0]);
            quantidadeItem = int.Parse(line[1]);

            double valorTotal = precos[codigoItem - 1] * quantidadeItem;
            Console.WriteLine($"Total: R$ {valorTotal:0.00}");
        }
    }
}
