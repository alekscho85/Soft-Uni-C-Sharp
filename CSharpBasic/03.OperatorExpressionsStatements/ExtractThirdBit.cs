using System;
namespace _11.ExtractThirdBit
{
    class ExtractThirdBit
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int moveRight = inputNumber >> 3;
            int bit = moveRight & 1;
            Console.WriteLine("Bit 3# is " + bit);
        }
    }
}
