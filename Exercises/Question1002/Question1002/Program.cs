using System;


namespace URI
{
    class Program
    {
        static void Main()
        {
            const double PI = 3.14159;
            double raio, area;
            
            raio = Convert.ToDouble(Console.ReadLine());
            area = PI * Math.Pow(raio, 2);
   
            Console.WriteLine($"A={area:0.0000}");
        }
    }
}

