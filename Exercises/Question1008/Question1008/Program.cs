using System;

namespace URI
{
    class Program
    {
        static void Main()
        {
            int numberFuncionario = Convert.ToInt32(Console.ReadLine());
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double salario = horasTrabalhadas * valorHora;
            Console.WriteLine($"NUMBER = {numberFuncionario}\nSALARY = U$ {salario:0.00}");
        }
    }
}
