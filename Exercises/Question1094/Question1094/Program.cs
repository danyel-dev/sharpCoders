using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int totCobaias = 0, cobaiasRatos = 0, cobaiasSapos = 0, cobaiasCoelhos = 0; 

            for(int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                int numCobaias = int.Parse(line[0]);
                totCobaias += numCobaias;

                switch (line[1]) {
                    case "R":
                    case "r":
                        cobaiasRatos += numCobaias;                     
                        break;
                    case "S":
                    case "s":
                        cobaiasSapos += numCobaias;
                        break;
                    case "C":
                    case "c":
                        cobaiasCoelhos += numCobaias;
                        break;
                }
            }

            Console.WriteLine($"Total: {totCobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {cobaiasCoelhos}");
            Console.WriteLine($"Total de ratos: {cobaiasRatos}");
            Console.WriteLine($"Total de sapos: {cobaiasSapos}");

            Console.WriteLine($"Percentual de coelhos: {(double)cobaiasCoelhos / totCobaias * 100:F2} %");
            Console.WriteLine($"Percentual de ratos: {(double)cobaiasRatos / totCobaias * 100:F2} %");
            Console.WriteLine($"Percentual de sapos: {(double)cobaiasSapos / totCobaias * 100:F2} %");
        }
    }
}
