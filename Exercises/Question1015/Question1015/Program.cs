namespace URI
{
    class Program
    {
        static void Main ()
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');

            double x1 = Convert.ToDouble(line1[0]);
            double y1 = Convert.ToDouble(line1[1]);
            double x2 = Convert.ToDouble(line2[0]);
            double y2 = Convert.ToDouble(line2[1]);
            
            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"{distancia:f4}");
        }
    }
}