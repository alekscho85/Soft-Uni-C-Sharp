using System;

namespace _05.TheBigestOfFiveNumbers
{
    class TheBigestOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("biggest is " + a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("biggest is " + b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("biggest is " + c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("biggest is " + d);
            }
            else
            {
                Console.WriteLine("biggest is " + e);
            }
        }
    }
}