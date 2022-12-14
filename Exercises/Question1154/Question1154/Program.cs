using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int count = 0, soma = 0;

            while(true)
            {
                int idade = int.Parse(Console.ReadLine());
                if(idade < 0)
                {
                    break; 
                }
                soma += idade;
                count++;
            }
            
            Console.WriteLine($"{ (double)soma / count:F2}");
        }
    }
}