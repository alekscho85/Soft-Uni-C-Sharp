using System;
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            //Loop to print all the numbers to the inputted number
            for (int i = 1; i <= n; i++ )
            {
                Console.Write(i);
            }
        }
    }
