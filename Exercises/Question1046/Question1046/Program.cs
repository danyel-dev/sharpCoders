using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');

            int duracaoJogo = 0;
            int horaInicio = int.Parse(line[0]);
            int horaTermino = int.Parse(line[1]);

            if (horaInicio == horaTermino) { 
                duracaoJogo = 24;
            }
            else if (horaInicio > horaTermino)
            {
                duracaoJogo = 24 - horaInicio + horaTermino;
            }
            else
            {
                duracaoJogo = horaTermino - horaInicio;
            }

            Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
        }
    }
}
