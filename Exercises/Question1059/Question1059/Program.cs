using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}