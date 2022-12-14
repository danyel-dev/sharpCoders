using System;

namespace URI
{
    class Program
    {
        static void Main()
        {
            int indice = 0, tempoSeg;
            int[] vetResult = { 0, 0, 0 }, vetTempos = { 3600, 60, 1 };

            tempoSeg = int.Parse(Console.ReadLine());

            while (tempoSeg > 0)
            {
                if (tempoSeg >= vetTempos[indice])
                {
                    vetResult[indice] = tempoSeg / vetTempos[indice];
                    tempoSeg = tempoSeg % vetTempos[indice];
                }
                else indice++;
            }

            Console.WriteLine($"{vetResult[0]}:{vetResult[1]}:{vetResult[2]}");
        }
    }
}
