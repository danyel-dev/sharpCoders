using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                string[] line = Console.ReadLine().Split(' ');
                Array.Sort(line);
         
                int M = int.Parse(line[0]);
                int N = int.Parse(line[1]);
                
                if(M <= 0 || N <= 0) {
                    break;
                }

                int somaInteiros = 0;

                for(int i = M; i <= N; i++)
                {
                    Console.Write(i + " ");
                    somaInteiros += i;
                }
                Console.WriteLine("Sum=" + somaInteiros);
            }
        }
    }
}
