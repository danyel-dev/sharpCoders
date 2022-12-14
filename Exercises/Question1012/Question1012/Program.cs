using System;

namespace URI
{
    class Program
    {
        static void Main()
        {
            string valores;
            valores = Console.ReadLine();

            double A = Convert.ToDouble(line.Split(' ')[0]);
            double B = Convert.ToDouble(valores.Split(' ')[1]);
            double C = Convert.ToDouble(valores.Split(' ')[2]);

            Console.WriteLine("TRIANGULO: " + (A * C / 2).ToString("f3"));
            Console.WriteLine("CIRCULO: " + (3.14159 * C * C).ToString("f3"));
            Console.WriteLine("TRAPEZIO: " + (C * (A + B) / 2).ToString("f3"));
            Console.WriteLine("QUADRADO: " + (B * B).ToString("f3"));
            Console.WriteLine("RETANGULO: " + (A * B).ToString("f3"));
        }
    }
}
