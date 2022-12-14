using System; 


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            int cont = 0;
            double somaNotas = 0;

            while(cont < 2)
            {
                double nota = double.Parse(Console.ReadLine());
                
                if(nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                } else
                {
                    cont++;
                    somaNotas += nota;
                }
            }

            Console.WriteLine("media = " + (somaNotas/cont).ToString("F2"));
        }
    }
}
