using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int numPartidas = 0, vitoriasInter = 0, vitoriasGremio = 0, empates = 0;

            while(true)
            {
                string[] line = Console.ReadLine().Split(' ');

                int golsInter = int.Parse(line[0]);
                int golsGremio = int.Parse(line[1]);

                numPartidas++;

                if(golsInter > golsGremio)
                {
                    vitoriasInter++;
                } 
                else if(golsGremio > golsInter)
                {
                    vitoriasGremio++;
                } 
                else
                {
                    empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");

                int option = int.Parse(Console.ReadLine());

                if(option == 2) {
                    break;
                }
            }

            Console.WriteLine($"{numPartidas} grenais");
            Console.WriteLine($"Inter:{vitoriasInter}");
            Console.WriteLine($"Gremio:{vitoriasGremio}");
            Console.WriteLine($"Empates:{empates}");

            if(vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if(vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
