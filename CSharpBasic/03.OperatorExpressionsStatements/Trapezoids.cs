using System;
namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double aBase, bBase, height;
            do
            {
                Console.Write("Please entar a valid A base of the trapezoid: ");
            } while (!(Double.TryParse(Console.ReadLine(), out aBase)));
            do
            {
                Console.Write("Please entar a valid B base of the trapezoid: ");
            } while (!(Double.TryParse(Console.ReadLine(), out bBase)));
            do
            {
                Console.Write("Please entar a valid height of the trapezoid: ");
            } while (!(Double.TryParse(Console.ReadLine(), out height)));

            double area = ((aBase + bBase) / 2) * height;
            Console.WriteLine("The area is: {0}", area);
        }
    }
}