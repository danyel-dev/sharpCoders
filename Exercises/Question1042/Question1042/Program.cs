using System;


namespace Beecrowd
{
    class Program
    {
        static void Main()
        {
            string[] values = Console.ReadLine().Split(' ');
            int[] numbers = new int[3];
            
            for(int i = 0; i < values.Length; i++)
            {
                numbers[i] = int.Parse(values[i]);
            }

            Array.Sort(numbers);

            Console.WriteLine($"{numbers[0]}\n{numbers[1]}\n{numbers[2]}");
            Console.WriteLine($"\n{values[0]}\n{values[1]}\n{values[2]}");
        }
    }
}
