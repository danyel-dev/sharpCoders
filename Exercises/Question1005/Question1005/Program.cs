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

            media = (A * 3.5 + B * 7.5) / 11;
            Console.WriteLine($"MEDIA = {media:N5}");
        }
    }
}
