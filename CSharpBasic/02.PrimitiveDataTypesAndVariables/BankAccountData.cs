using System;
using System.Linq;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Enter First name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last name: ");
        string lastName = Console.ReadLine();

        byte age = 0;
        do
        {
            Console.Write("Enter age: ");
        }
        while (!byte.TryParse(Console.ReadLine(), out age) || (age < 0 || age > 120));

        char gender = ' ';
        do
        {
            Console.Write("Enter gander, m / f: ");
        }
        while (!char.TryParse(Console.ReadLine(), out gender) || (char.ToLower(gender) != 'f' && char.ToLower(gender) != 'm'));

        uint idNumber = 0;
        do
        {
            Console.Write("Enter ID number: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out idNumber) || (idNumber < 27560000 || idNumber > 27569999));

        Console.WriteLine();
        Console.WriteLine("Your name is {0} {1}", firstName, lastName);
        Console.WriteLine("Your age is {0}", age);
        Console.WriteLine("Your gender is {0}", (gender == 'm') ? "Male" : "Female");
        Console.WriteLine("Your ID number is: {0}", idNumber);
    }
}