using System;


namespace URI
{
    class Program
    {
        static void Main()
        {
            string nome = Console.ReadLine();
            double salario = Convert.ToDouble(Console.ReadLine());
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            double salarioFinal = salario + (15.0 / 100.0 * totalVendas);
            Console.WriteLine($"TOTAL = R$ {salarioFinal:0.00}");
        }
    }
}
