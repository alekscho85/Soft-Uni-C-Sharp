using System;

namespace _12.RandomizeTheNumbers1_N
{
    class RandomizeTheNumbers1_N
    {
        static void Main()
        {
            Console.Write("Enter n number");
            int n = int.Parse(Console.ReadLine());
            Random randomNumbers = new Random();
            for (int i = 0; i <= n; i++)
            {
                Console.Write(randomNumbers.Next(1, n + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}
