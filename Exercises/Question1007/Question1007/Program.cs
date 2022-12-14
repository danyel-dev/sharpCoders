using System;


namespace URI
{
    class Program
    {
        static void Main()
        {   
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());

            int diferenca = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
