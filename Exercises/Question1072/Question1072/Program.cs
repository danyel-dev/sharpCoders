using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int countIn = 0, countOut = 0;

            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    countIn++;
                }
                else
                {
                    countOut++;
                }
            }

            Console.WriteLine($"{countIn} in");
            Console.WriteLine($"{countOut} out");
        }
    }
}