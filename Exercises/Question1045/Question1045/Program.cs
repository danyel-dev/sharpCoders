using System;


namespace Beecrowd
{
    class Program {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            double[] values = new double[3];

            for(int i = 0; i < line.Length; i++)
            {
                values[i] = double.Parse(line[i]);
            }

            Array.Sort(values);
            Array.Reverse(values);

            double A = values[0];
            double B = values[1];
            double C = values[2];

            if(A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } 
            else
            {
                if((A * A) == (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if((A * A) > (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if((A * A) < (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                
                if(A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if(A == B || A == C || B == C) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
