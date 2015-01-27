using System;
    class NumbersIntervalDividableGivenNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter first number (must be positive).");
            uint firstN = uint.Parse(Console.ReadLine());
            while (firstN <= 0)
            {              
                Console.WriteLine("First number must be positive! Try again.");
                firstN = uint.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter second number (must be positive).");
            uint secondN = uint.Parse(Console.ReadLine());
            while (secondN <=0)
            {
                Console.WriteLine("Second number must be positive! Try again.");
                secondN = uint.Parse(Console.ReadLine());
            }
            uint numsBetweenFirstAndSecond = secondN - firstN;
            Console.WriteLine("Numbers between the first and the second number you entered: {0}", numsBetweenFirstAndSecond);
            uint p = 0;
            p = numsBetweenFirstAndSecond / 5;
            bool existingDivisibleNums = p == 0;
            if (existingDivisibleNums)
            {
                Console.WriteLine("There are no numbers divisible by 5 in this interval!");                
            }
            else if (secondN % 5 == 0)
            {
                Console.WriteLine("Numbers divisible by 5 without remainder in this interval: {0}", (p + 1));
            }
            else
            {
                Console.WriteLine("Numbers divisible by 5 without remainder in this interval: {0}", p);                
            }
            Console.Write("Numbers whose remainder of the division by 5 is 0: ");
            string result = string.Empty;
            for (uint i = firstN; i <= secondN; i++)
            {                
                if (i % 5 == 0)
                {                    
                    result += i + ", ";                    
                }                
            }
            if (!string.IsNullOrEmpty(result))
            {
                result = result.Substring(0, result.Length - 2);
            }
            Console.WriteLine(result); 
        }
    }