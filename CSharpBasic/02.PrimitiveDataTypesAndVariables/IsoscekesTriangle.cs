using System;
using System.Text;
namespace IsoscekesTriangle
{
    class IsoscekesTriangle
    {
        static void Main()
        {
            char copyRight = '©';
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(@"
     {0}
    {0}{0}
   {0}  {0}
  {0}{0}{0}{0}", copyRight);

        }
    }
}