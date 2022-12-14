using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string[] ladosTriangulo = Console.ReadLine().Split(' ');
            
            double A = double.Parse(ladosTriangulo[0]);
            double B = double.Parse(ladosTriangulo[1]);
            double C = double.Parse(ladosTriangulo[2]);

            if(A >= B + C || B >= A + C || C >= A + B)
            {
                double area = C / 2 * (A + B);
                Console.WriteLine($"Area = {area:F1}");
            } 
            else
            {
                double perimetro = A + B + C;
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            }
        }
    }
}
