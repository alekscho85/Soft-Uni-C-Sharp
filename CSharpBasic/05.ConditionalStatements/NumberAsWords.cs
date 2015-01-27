using System;
namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            Console.Write("N = ");
            int number = int.Parse(Console.ReadLine());
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] specials = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen" };
            string[] onesCapital = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] tensCapital = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] specialsCapital = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
            "Seventeen", "Eighteen", "Nineteen" };
            int thirdNumber = number % 10;
            int secondNumber = (number / 10) % 10;
            int firstNumber = number / 100;
            if (number < 10)
            {
                Console.WriteLine(ones[number]);
            }
            else if (number % 100 == 0)
            {
                Console.WriteLine(onesCapital[firstNumber] + " hundred");
            }
            else if (secondNumber == 0)
            {
                Console.WriteLine(onesCapital[firstNumber] + " hundred and " + ones[thirdNumber]);
            }
            else if (secondNumber == 1)
            {
                if (firstNumber < 1)
                {
                    Console.WriteLine(specialsCapital[thirdNumber]);
                }
                else
                {
                    Console.WriteLine("{0} hundred and {1}", onesCapital[firstNumber], specials[thirdNumber]);
                }
            }
            else if (thirdNumber == 0)
            {
                if (number < 100)
                {
                    Console.WriteLine(tensCapital[secondNumber - 2]);
                }
                else
                {
                    Console.WriteLine("{0} hundred and {1}", onesCapital[firstNumber], tens[secondNumber - 2]);
                }
            }
            else if ((secondNumber > 1) && (thirdNumber != 0))
            {
                if (firstNumber < 1)
                {
                    Console.WriteLine("{0} {1}", tensCapital[secondNumber - 2], ones[thirdNumber]);
                }
                else
                {
                    Console.WriteLine("{0} hundred and {1} {2}", onesCapital[firstNumber], tens[secondNumber - 2], ones[thirdNumber]);
                }
            }
        }
    }
}
