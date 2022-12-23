using System;


namespace jogoDaVelha
{
    class Program
    {
        static void Main()
        {
            int jogada;
            char[] vet = new char[9];

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"  { vet[0]} | {vet[1]}  | {vet[2]} ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($"  {vet[3]} | {vet[4]}  | {vet[5]} ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($"  {vet[6]} | {vet[7]}  | {vet[8]} ");
                Console.WriteLine();

                Console.Write("Escolha uma posição para jogar: ");

                jogada = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    vet[jogada] = 'X';
                }
                else
                {
                    vet[jogada] = 'O';
                }

                Console.WriteLine();
            }
        }
    }
}
