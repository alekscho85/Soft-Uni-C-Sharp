using System;
namespace _01.OddOrEvenIntegers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Check if the number is odd:");
            int Number;
            string Resul = Console.ReadLine();
            int.TryParse(Resul, out Number);

            if (Number % 2 == 0)
            {
                Console.WriteLine("Number is even:" + Number);
                Console.WriteLine("False");

            }
            else
            {
                Console.WriteLine("Number is odd:" + Number);
                Console.WriteLine("True"); 
            }
        }
    }
}
