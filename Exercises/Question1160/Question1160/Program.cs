using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for(int i = 0; i < T; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                int populacaoA = int.Parse(line[0]);
                int populacaoB = int.Parse(line[1]);

                double crescimentoA = double.Parse(line[2]);
                double crescimentoB = double.Parse(line[3]);

                int countDias = 0;

                while(populacaoA <= populacaoB)
                {
                    double percentualA = crescimentoA / 100 * populacaoA;
                    populacaoA += (int)percentualA;

                    double percentualB = crescimentoB / 100 * populacaoB;
                    populacaoB += (int)percentualB;

                    countDias++;
                }

                if (countDias > 100) {
                    Console.WriteLine("Mais de 1 seculo.");
                } else
                {
                    Console.WriteLine(countDias + " anos.");
                }
            }
        }
    }
}
