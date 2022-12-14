using System;


namespace URI
{
    class Program
    {
        static void Main()
        {
            int A, B, X;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            X = A + B;
            Console.WriteLine($"X = {X}");
        }
    }
}
