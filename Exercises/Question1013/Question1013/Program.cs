namespace URI
{
    class Program
    {
        static void Main ()
        {
            string line = Console.ReadLine();
           
            int A = Convert.ToInt32(line.Split(' ')[0]);
            int B = Convert.ToInt32(line.Split(' ')[1]);
            int C = Convert.ToInt32(line.Split(' ')[2]);

            int maior = (A + B + Math.Abs(A - B)) / 2;
            int maior2 = (maior + C + Math.Abs(maior - C)) / 2;
            Console.WriteLine (maior2 + " eh o maior");  
        }
    }
}
