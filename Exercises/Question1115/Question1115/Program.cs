using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            for(; ; )
            {
                string[] line = Console.ReadLine().Split(' ');

                int X = int.Parse(line[0]);
                int Y = int.Parse(line[1]);

                if(X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if(X > 0 && Y < 0) {
                    Console.WriteLine("quarto");
                }
                else if(X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                } 
                else if(X < 0 && Y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
