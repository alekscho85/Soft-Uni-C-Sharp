using System;
namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            uint num = uint.Parse(Console.ReadLine());

            num = (num & (~(7u << 3 | 7u << 24))) | (((num & (7u << 3)) << 21) | ((num & (7u << 24)) >> 21));
            Console.WriteLine(num);
        }
    }
}
