using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            
            int aux = 1;
            
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{aux} {aux + 1} {aux + 2} PUM");
                aux += 4;
            }
        }
    }
}
