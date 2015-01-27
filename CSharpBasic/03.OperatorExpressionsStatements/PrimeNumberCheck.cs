using System;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                }
            }
            Console.WriteLine(prime);
        }
    }
}
