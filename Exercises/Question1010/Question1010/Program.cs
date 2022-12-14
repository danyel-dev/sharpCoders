using System;


namespace URI
{
    class Program
    {
        static void Main() {
            string[] linePeca1 = Console.ReadLine().Split(' ');
            string[] linePeca2 = Console.ReadLine().Split(' ');

            double peca1 = Convert.ToDouble(linePeca1[1]) * Convert.ToDouble(linePeca1[2]);
            double peca2 = Convert.ToDouble(linePeca2[1]) * Convert.ToDouble(linePeca2[2]);
            double valorTotal = peca1 + peca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("f2"));
        }
    }
}
