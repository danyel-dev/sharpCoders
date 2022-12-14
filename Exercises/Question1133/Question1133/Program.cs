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

            for (int i = menor + 1; i < maior; i++)
            {
                if(i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}