using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            double diferenca = 0, ir = 0;

            double salario = double.Parse(Console.ReadLine());

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            } 
            else
            {
                diferenca = salario - 2000;

                if(diferenca < 1000)
                {
                    ir += (double)8 / 100 * diferenca;
                } 
                else
                {
                    ir += (double)8 / 100 * 1000;

                    diferenca = salario - 3000;

                    if(diferenca <= 1500)
                    {
                        ir += (double)18 / 100 * diferenca;
                    } 
                    else
                    {
                        ir += (double)18 / 100 * 1500;

                        diferenca = salario - 4500;

                        if(diferenca > 0)
                        {
                            ir += (double)28 / 100 * diferenca;
                        }
                    }
                }

                Console.WriteLine($"R$ {ir:F2}");
            }
        }
    }
}
