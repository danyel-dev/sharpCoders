using System;

namespace URI
{
    class Program
    {
        static void Main()
        {
            double X1 = 0, X2 = 0;

            string[] values = Console.ReadLine().Split(' ');

            double A = double.Parse(values[0]);
            double B = double.Parse(values[1]);
            double C = double.Parse(values[2]);

            double delta = (B * B) - (4 * A * C);

            if(delta < 0 || 2 * A == 0) {
                Console.WriteLine("Impossivel calcular");
            } else {
                X1 = (-B + Math.Sqrt(delta)) / (2 * A);
                X2 = (-B - Math.Sqrt(delta)) / (2 * A);
                
                Console.WriteLine($"R1 = {X1:0.00000}\nR2 = {X2:0.00000}"); 
            }
        }
    }
}
