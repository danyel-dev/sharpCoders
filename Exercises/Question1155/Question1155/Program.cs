using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            double S = 1;
            
            for(int i = 2; i <= 100; i++)
            {
                S += 1.0/i;
            }

            Console.WriteLine($"{S:F2}");
        }
    }
}
