using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(':');
            string[] line3 = Console.ReadLine().Split(' ');
            string[] line4 = Console.ReadLine().Split(':');

            int[] horario1 = { int.Parse(line1[1]), int.Parse(line2[0]), int.Parse(line2[1]), int.Parse(line2[2])};
            int[] horario2 = { int.Parse(line3[1]), int.Parse(line4[0]), int.Parse(line4[1]), int.Parse(line4[2]) };

            int segundos, minutos, horas, dias;

            segundos = horario2[3] - horario1[3];
            minutos = horario2[2] - horario1[2];
            horas = horario2[1] - horario1[1];
            dias = horario2[0] - horario1[0];

            if(segundos < 0)
            {
                segundos += 60;
                minutos--;
            }

            if(minutos < 0)
            {
                minutos += 60;
                horas--;
            }

            if(horas < 0)
            {
                horas += 24;
                dias--;
            }

            Console.WriteLine($"{dias} dia(s)\n{horas} hora(s)\n{minutos} minuto(s)\n{segundos} segundo(s)");
        }
    }
}
