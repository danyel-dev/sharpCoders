using System;

namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                double nota1, nota2;

                while(true) { 
                    nota1 = double.Parse(Console.ReadLine());
                    
                    if (nota1 < 0 || nota1 > 10)  
                        Console.WriteLine("nota invalida");
                    else break;
                }

                while(true)
                {
                    nota2 = double.Parse(Console.ReadLine());
                
                    if (nota2 < 0 || nota2 > 10) 
                        Console.WriteLine("nota invalida");
                    else break;
                }

                if((nota1 >= 0 && nota1 <= 10) && (nota2 >= 0 && nota2 <= 10)) { 
                    Console.WriteLine($"media = {(nota1 + nota2) / 2:F2}");
                    int flag = 1;

                    while (true) {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        int X = int.Parse(Console.ReadLine());

                        if (X == 1 || X == 2) {
                            if(X == 2) flag = 2;
                            break;
                        }
                    }

                    if (flag == 2) break;
                }
            }
        }
    }
}