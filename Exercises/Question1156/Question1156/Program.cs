using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            double S = 1;
            double aux = 2.0;

            for(int i = 3; i <= 39; i+=2)
            {
                S += i / aux;
                aux *= 2.0;
            }

            Console.WriteLine(S.ToString("F2"));
        }
    }
}