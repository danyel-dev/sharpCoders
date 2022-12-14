using System;


namespace URI
{
    class Program
    {
        static void Main()
        {
            string[] values = Console.ReadLine().Split(' ');
            
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);
            int C = int.Parse(values[2]);
            int D = int.Parse(values[3]);

            if((B > C && D > A) && (C + D > A + B) && (C > 0 && D > 0) && (A % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            } else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
