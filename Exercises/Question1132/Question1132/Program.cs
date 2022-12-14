using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int maior = X, menor = Y;
            
            if(Y > X)
            {
                maior = Y;
                menor = X;
            }

            int somaNaoMultiplos = 0;

            for (int i = menor; i <= maior; i++)
            {
                if(i % 13 != 0)
                {
                    somaNaoMultiplos += i;
                }
            }

            Console.WriteLine(somaNaoMultiplos);
        }
    }
}
