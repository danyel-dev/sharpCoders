using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int maior = (X + Y + Math.Abs(X - Y)) / 2;
            int menor = (X + Y - Math.Abs(X - Y)) / 2;

            int somaImpares = 0;

            for(int i = menor + 1; i < maior; i++)
            {
                if(i % 2 != 0)
                {
                    somaImpares += i;
                }
            }

            Console.WriteLine(somaImpares);
        }
    }
}
