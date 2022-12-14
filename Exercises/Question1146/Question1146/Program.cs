using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            Int16 X = Int16.Parse(Console.ReadLine());
            
            while(X != 0) {
                for (int i = 1; i <= X; i++) {
                    if (i == X)
                        Console.WriteLine($"{i}");
                    else
                        Console.Write($"{i} ");
                }

                X = Int16.Parse(Console.ReadLine());
            }
        }
    }
}
