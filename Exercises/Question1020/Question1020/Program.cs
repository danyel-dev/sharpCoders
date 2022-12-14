using System;


namespace URI
{
    class Program
    {
        static void Main()
        {
            int idadeEmDias = int.Parse(Console.ReadLine());

            int anos = idadeEmDias / 365;
            idadeEmDias %= 365;

            int meses = idadeEmDias / 30;
            idadeEmDias %= 30;

            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{idadeEmDias} dia(s)");
        }
    }
}
