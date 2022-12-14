using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                int X = int.Parse(Console.ReadLine());

                if(X == 0)
                {
                    break;
                }

                int count = 0, soma = 0;

                while (count < 5)
                {
                    if (X % 2 == 0)
                    {
                        soma += X;
                        count++;
                    }
                    X++;
                }

                Console.WriteLine(soma);
            }
        }
    }
}
