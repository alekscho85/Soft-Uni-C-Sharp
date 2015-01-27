using System;
namespace _02.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert company name:");
            string company = Console.ReadLine();
            Console.WriteLine("Insert company phone number:");
            int numberCompany = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert company fax number:");
            int faxCompany = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert company web site:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Insert company manager's first name:");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Insert company manager's last name:");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Insert company manager's age:");
            int ageManager = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert company manager's phone number:");
            int numberManager = int.Parse(Console.ReadLine());
            Console.WriteLine("Company information: {0}, phone number: {1}, fax: {2}, web site: {3}.",
            company, numberCompany, faxCompany, webSite);
            Console.WriteLine("Manager: {0} {1}.", managerFirstName, managerLastName);
            Console.WriteLine("Manager age: {0}, phone number: {1}.", ageManager, numberManager);
        }
    }
}
