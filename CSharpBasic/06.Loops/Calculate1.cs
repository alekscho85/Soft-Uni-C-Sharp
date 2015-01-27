using System;

namespace _05.Calculate1_
{
    class Calculate1
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number x: ");
            int x = int.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                double xPow = Math.Pow(x, i);
                double addend = factorial / xPow;
                sum += addend;
            }
            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}
