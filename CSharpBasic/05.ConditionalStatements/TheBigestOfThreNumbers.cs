using System;
namespace _06.TheBigestOfThreNumbers
{
    class TheBigestOfThreNumbers
    {
        static void Main()
        {
            Console.Write("Number1 = ");
            double Number1 = double.Parse(Console.ReadLine());
            Console.Write("Number2 = ");
            double Number2 = double.Parse(Console.ReadLine());
            Console.Write("Number3 = ");
            double Number3 = double.Parse(Console.ReadLine());

            if (Number1 > Number2 && Number1 > Number3)
            {
                Console.WriteLine("Biggest Number is " + Number1);
            }
            else if (Number2 > Number1 && Number2 > Number3)
            {
                Console.WriteLine("Bigest Number is " + Number2);
            }
            else if (Number3 > Number1 && Number3 > Number2)
            {
                Console.WriteLine("Bigest Number is " + Number3);
            }
        }
    }
}
