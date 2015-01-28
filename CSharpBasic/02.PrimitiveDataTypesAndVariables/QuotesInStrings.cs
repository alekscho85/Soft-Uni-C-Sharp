using System;
namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string Hallo = "Hallo";
            string World = "World";
            object objSequence = Hallo + " " + World;
            string strSequence = Convert.ToString(objSequence);
            Console.WriteLine("{0}", strSequence);
        }
    }
}
