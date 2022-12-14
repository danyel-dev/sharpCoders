namespace URI
{
    class Program
    {
        static void Main()
        {
            int distancia = Convert.ToInt32(Console.ReadLine());
            double combustivel = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"{distancia/combustivel:F3} km/l");
        }
    }
}