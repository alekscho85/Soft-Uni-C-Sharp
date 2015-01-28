using System;
namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            char Unicode = 'H';
            int Num;
            Console.WriteLine("Char: " + Unicode);
            Console.WriteLine("Code: " + (int)Unicode);
            Num = (int)Unicode;
            Console.WriteLine("Hexadecimal: " + 0x72);
        }
    }
}
