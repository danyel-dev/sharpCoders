using System;
using System.Security.Cryptography.X509Certificates;

namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());

            while(Z <= X)
                Z = int.Parse(Console.ReadLine());

            int count = 0, soma = 0;

            for (int i = X; i <= Z; i++) {
                if(soma < Z)
                {
                    count++;
                    soma += i;
                } else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
