using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            int countImpares = 0;

            while(countImpares < 6)
            {
                if (X % 2 != 0)
                {
                    Console.WriteLine(X);
                    countImpares++;
                }
                X++;
            }
        }
    }
}