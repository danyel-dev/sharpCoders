using System;


namespace URI
{
    class Program
    {
        static void Main()
        {
            int PROD;
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());

            PROD = valor1 * valor2;
            Console.WriteLine("PROD = " + PROD);
        }
    }
} 