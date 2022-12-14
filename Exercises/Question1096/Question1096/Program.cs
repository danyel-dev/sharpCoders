using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int aux = 7;

            for(int i = 1; i <= 9; i += 2)
            {
                for (int j = aux; j >= aux - 2; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
                
                aux += 2;
            }
        }
    }
}
