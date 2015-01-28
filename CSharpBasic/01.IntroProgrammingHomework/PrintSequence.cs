using System;

    class PrintSequence
    {
        static void Main()
        {
            int number = 2;
            for (int i = 0; i < 10; i++)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number++);
                }
                else
                {
                    Console.WriteLine("-{0}", number);
                    number++;
                }
            }
        }
    }
