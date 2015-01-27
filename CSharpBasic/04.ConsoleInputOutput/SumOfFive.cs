using System;
    class SumOfFive
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Please enter 5 numbers");
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                string bString = Console.ReadLine();                             
                bool tryParse = int.TryParse(bString,out numbers[i]);
                Console.WriteLine(tryParse ? "Enter the next number" : "Invalid number");
            }

            int sum = (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]);
            Console.WriteLine("The sum of your number is : " + sum);
        }
    }