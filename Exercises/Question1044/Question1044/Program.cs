using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');

            int A = int.Parse(line[0]);
            int B = int.Parse(line[1]);

            int menor = (A + B - Math.Abs(A - B)) / 2;
            int maior = (A + B + Math.Abs(A - B)) / 2;

            if (maior % menor == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
