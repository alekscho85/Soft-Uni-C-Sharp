using System;
namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int evenNumber = 1;
            int oddNumber = 1;
            Console.WriteLine("Please, enter some numbers: ");
            string readNumbers = Console.ReadLine();
            string[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                if (i % 2 == 0)
                {
                    evenNumber *= number;
                }
                else
                {
                    oddNumber *= number;
                }
            }
            if (evenNumber == oddNumber)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + evenNumber);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + oddNumber);
                Console.WriteLine("even_product = " + evenNumber);
            }
        }
    }
}
