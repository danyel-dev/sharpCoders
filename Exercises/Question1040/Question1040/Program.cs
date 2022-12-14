using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            double nota1, nota2, nota3, nota4, media, notaExame, mediaFinal;

            string[] line = Console.ReadLine().Split(' ');

            nota1 = double.Parse(line[0]);
            nota2 = double.Parse(line[1]);
            nota3 = double.Parse(line[2]);
            nota4 = double.Parse(line[3]);

            media = Math.Truncate(nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4 * 1) / 10;
            Console.WriteLine($"Media: {media:F1}");

            if(media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            } 
            else if(media < 5) {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");

                notaExame = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaExame:F1}");

                mediaFinal = (notaExame + media) / 2;

                if(mediaFinal >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                } 
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine($"Media final: {mediaFinal:F1}");
            }
        }
    }
}
