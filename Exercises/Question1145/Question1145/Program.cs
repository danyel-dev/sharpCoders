using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');

            int X = int.Parse(line[0]);
            int Y = int.Parse(line[1]);

            for(int i = 1; i <= Y; i++)
            {
                if(i % X == 0)
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
