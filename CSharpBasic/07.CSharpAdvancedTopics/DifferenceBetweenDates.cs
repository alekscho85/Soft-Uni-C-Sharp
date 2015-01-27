using System;
namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            TimeSpan daysInBetween = endDate - startDate;

            bool check = (startDate <= endDate);
            //bool checed = (startDate > endDate);
            if (check)
            {
                Console.WriteLine("{0:%d}", daysInBetween);
            }
             else// if (checed)
            {
                Console.WriteLine("-{0:%d}", daysInBetween);
            }
         }
     }
}
