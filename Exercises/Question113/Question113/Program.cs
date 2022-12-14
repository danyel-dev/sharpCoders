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

                int X = int.Parse(line[0]);
                int Y = int.Parse(line[1]);

                if(X == Y)
                {
                    break;
                }

                if(X > Y)
                {
                    Console.WriteLine("Decrescente");
                } 
                else
                {
                    Console.WriteLine("Crescente");
                }
            }
        }
    }
}