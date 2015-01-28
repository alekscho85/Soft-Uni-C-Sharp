using System;
namespace JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main()
        {

            string isLeapYear = Console.ReadLine();

            ushort numHolidays = ushort.Parse(Console.ReadLine());

            byte hometownWekends = byte.Parse(Console.ReadLine());

            int plays = hometownWekends + (((52 - hometownWekends) * 2 / 3) + numHolidays / 2);


            if (isLeapYear == "t")
            {
                plays = plays + 3;
            }

            Console.WriteLine(plays);


        }
    }
}