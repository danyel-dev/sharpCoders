using System;

namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int contPares = 0;

            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    contPares++;
                }
            }

            Console.WriteLine($"{contPares} valores pares");
        }
    }
}
