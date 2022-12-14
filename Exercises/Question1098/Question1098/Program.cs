using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            double aux = 0;
            int count = 0;

            for(double i = 0.0; i <= 2; i+=0.2)
            {
               for(double j = 1; j <= 3; j++)
               {
                    if (count == 0)
                    {
                        Console.WriteLine($"I={i:F0} J={j+aux:F0}");
                    } else
                    {
                        Console.WriteLine($"I={i:F1} J={j+aux:F1}");
                    }
               }

               aux += 0.2;
               count++;
               
               if(count == 5)
               {
                    count = 0;
               }
            }
        }
    }
}
