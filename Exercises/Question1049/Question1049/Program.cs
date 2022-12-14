using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string palavra1 = Console.ReadLine().ToLower();
            string palavra2 = Console.ReadLine().ToLower();
            string palavra3 = Console.ReadLine().ToLower();

            if (palavra1 == "vertebrado")
            {
                if (palavra2 == "ave")
                {
                    if (palavra3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    } 
                    else if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                } 
                else if (palavra2 == "mamifero")
                {
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (palavra3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            } 
            else if (palavra1 == "invertebrado")
            {
                if (palavra2 == "inseto")
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (palavra3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (palavra2 == "anelideo")
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            } 
        }
    }
}
