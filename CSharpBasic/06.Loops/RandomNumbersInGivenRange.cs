using System;
namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("Enter number n for range:  ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Min =  ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Max =  ");
            int max = int.Parse(Console.ReadLine());
            if (min < max)
            {
                Random numbers = new Random();
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(numbers.Next(min, max + 1) + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadLine();
        }
    }
}
