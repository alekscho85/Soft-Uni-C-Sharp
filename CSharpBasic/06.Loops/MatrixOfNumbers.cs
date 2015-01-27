using System;
namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Ènter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("{0,3}", row + col - 1);
                }
                Console.WriteLine();
            }
        }
    }
}