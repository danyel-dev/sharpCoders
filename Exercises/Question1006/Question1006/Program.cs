using System;


namespace URI
{
    class Program
    {
        static void Main()
        {
            double media;
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            media = (A*2 + B*3 + C*5) / 10;
            Console.WriteLine($"MEDIA = {media:N5}");
        }
    }
}
