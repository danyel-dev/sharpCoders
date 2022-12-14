using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string[] listaMeses = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int numeroMes = int.Parse(Console.ReadLine());

            Console.WriteLine(listaMeses[numeroMes - 1]);
        }
    }
}
