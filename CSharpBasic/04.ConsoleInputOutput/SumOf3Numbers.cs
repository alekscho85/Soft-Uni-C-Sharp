using System;
namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Insert first number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert second number:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert third number:");
            double num3 = double.Parse(Console.ReadLine());
            double sum = num1 + num2 + num3;
            Console.WriteLine("The sum of the three numbers is: {0}.", sum);
        }
    }
}
