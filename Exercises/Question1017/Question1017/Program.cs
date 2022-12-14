namespace URI
{
    class Program
    {
        static void Main ()
        {
            const double AUTOMOVEL = 12;
            
            int tempoViagem = Convert.ToInt32(Console.ReadLine());
            int velMedia = Convert.ToInt32(Console.ReadLine());
            
            double litrosViagem = tempoViagem * velMedia / AUTOMOVEL;
            Console.WriteLine($"{litrosViagem:f3}");
        }
    }
}
