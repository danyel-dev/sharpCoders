using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                int password = int.Parse(Console.ReadLine());

                if(password == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                } else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
