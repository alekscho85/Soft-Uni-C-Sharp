using System;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Program reads a number N and prints on the console first N members of the Fibonacci sequence.");
            Console.WriteLine("Enter number:");
            int n = Int32.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
