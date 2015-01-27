using System;
namespace _02.NumbersNotDivisibleBy3and7V2
{
    class NumbersNotDivisibleBy3and7V2
    {
        static void Main()
        {
            // We get one number
            Console.WriteLine("Show me all numbers (not divisible by 3 and 7)");
            Console.Write("Enter n= ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // We skip numbers that can be divided by 3 and 7 here and print the rest
                if (!(i % 3 == 0) && !(i % 7 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
