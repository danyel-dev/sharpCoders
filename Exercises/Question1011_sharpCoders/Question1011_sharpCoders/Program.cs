using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            const double PI = 3.14159;
            double R = double.Parse(Console.ReadLine());

            double volume = (4.0/3) * PI * R * R * R;

            Console.WriteLine($"VOLUME = {volume:F3}");
        }
    }
}