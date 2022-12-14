using System;

namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            const int NUM = 100;

            decimal X = decimal.Parse(Console.ReadLine());

            decimal[] N = new decimal[NUM];

            for(int i = 0; i < NUM; i++)
            {
                N[i] = X;
                Console.WriteLine($"N[{i}] = {decimal.Round(N[i], 4, MidpointRounding.ToEven)}");
                X /= 2;
            }
        }
    }
}
