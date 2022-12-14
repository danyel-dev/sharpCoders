using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                double num1 = double.Parse(line[0]);
                double num2 = double.Parse(line[1]);

                if(num2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                } else
                {
                    double result = num1 / num2;
                    Console.WriteLine(result.ToString("F1"));
                }

            }
        }
    }
} 
