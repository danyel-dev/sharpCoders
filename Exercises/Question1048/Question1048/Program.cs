using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            double novoSalario = 0, reajusteGanho = 0, percentual = 0;

            double salario = double.Parse(Console.ReadLine());

            if (salario <= 400)
            {
                percentual = 15;
                reajusteGanho = percentual / 100 * salario;
                novoSalario = salario + reajusteGanho;
            }
            else if (salario <= 800) {
                percentual = 12;
                reajusteGanho = percentual / 100 * salario;
                novoSalario = salario + reajusteGanho;
            }
            else if (salario <= 1200)
            {
                percentual = 10;
                reajusteGanho = percentual / 100 * salario;
                novoSalario = salario + reajusteGanho;
            }
            else if (salario <= 2000)
            {
                percentual = 7;
                reajusteGanho = percentual / 100 * salario;
                novoSalario = salario + reajusteGanho;
            }
            else 
            {
                percentual = 4;
                reajusteGanho = percentual / 100 * salario;
                novoSalario = salario + reajusteGanho;
            }

            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }
    }
}
