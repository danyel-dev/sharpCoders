using System;


namespace Beecrowd {
    class Program
    {
        static void Main() {
            string[] line = Console.ReadLine().Split(' '); 

            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            } 
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
