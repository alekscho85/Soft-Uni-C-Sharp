using System;
namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string firstStr = "Hello";
            string secondStr = "World";
            object myObject = firstStr + " " + secondStr; 
            string thirdStr = (string)myObject; 
            Console.WriteLine(thirdStr);
        }
    }
}
