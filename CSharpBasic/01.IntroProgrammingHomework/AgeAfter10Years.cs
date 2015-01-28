using System;
class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("My birthday date:  ");
        DateTime myBirthday = DateTime.Parse(Console.ReadLine());

        DateTime DateNow = DateTime.Now;

        var myAge = DateNow.Year - myBirthday.Year;
        Console.WriteLine("My age: " + myAge);

        var futureAge = myAge + 10;
        Console.WriteLine("My age after 10 years : " + futureAge);
    }
}