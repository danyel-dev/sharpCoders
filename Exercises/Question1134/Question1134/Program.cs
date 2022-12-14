using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int contAlcool = 0, contGasolina = 0, contDiesel = 0;

            while(true)
            {
                int codCombustivel = int.Parse(Console.ReadLine());

                if(codCombustivel == 1)
                {
                    contAlcool++;
                }
                else if(codCombustivel == 2)
                {
                    contGasolina++;
                }
                else if(codCombustivel == 3)
                {
                    contDiesel++;
                }
                else if (codCombustivel == 4)
                {
                    break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {contAlcool}");
            Console.WriteLine($"Gasolina: {contGasolina}");
            Console.WriteLine($"Diesel: {contDiesel}");
        }
    }
}