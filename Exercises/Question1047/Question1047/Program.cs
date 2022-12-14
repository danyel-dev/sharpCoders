using System;

namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int duracaoHoras, duracaoMinutos = 0;
            string[] line = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(line[0]);
            int minutoInicial = int.Parse(line[1]);
            int horaFinal = int.Parse(line[2]);
            int minutoFinal = int.Parse(line[3]);

            duracaoHoras = horaFinal - horaInicial;
            duracaoMinutos = minutoFinal - minutoInicial;

            if(duracaoMinutos < 0)
            {
                duracaoMinutos += 60;
                duracaoHoras--;
            }

            if(duracaoHoras < 0)
            {
                duracaoHoras += 24;
            }

            if(duracaoHoras == 0 && duracaoMinutos == 0)
            {
                duracaoHoras = 24;
            }

            Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");
        }
    }
}
