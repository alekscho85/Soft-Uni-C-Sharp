using System;
using System.Text;

class ProgrammingLanguages
{
    static void Main()
    {
        string topicCSharp = "C# it is a Microsoft programming language developed to compete with Sun's Java language. C# is an object-oriented programming language used with XML-based Web services on the .NET platform and designed for improving productivity in the development of Web applications. C# boasts type-safety, garbage collection, simplified type declarations, versioning and scalability support, and other features that make developing solutions faster and easier, especially for COM+ and Web services. Microsoft critics have pointed to the similarities between C# and Java. ";
        string topicVisualBasic = "A programming language and environment developed by Microsoft. Based on the BASIC language, Visual Basic was one of the first products to provide a graphical programming environment and a paint metaphor for developing user interfaces. Instead of worrying about syntax details, the Visual Basic programmer can add a substantial amount of code simply by dragging and dropping controls, such as buttons and dialog boxes, and then defining their appearance and behavior.";
        string topicJava = "Developed by Sun Microsystems.Java is an object-oriented language similar to C++, but simplified to eliminate language features that cause common programming errors. Java source code files (files with a .java extension) are compiled into a format called bytecode (files with a .class extension), which can then be executed by a Java interpreter. Compiled Java code can run on most computers because Java interpreters and runtime environments, known as Java Virtual Machines (VMs), exist for most operating systems, including UNIX, the Macintosh OS, and Windows.";
        string topicCPP = "A high-level programming language developed by Bjarne Stroustrup at Bell Labs. C++ adds object-oriented features to its predecessor, C. C++ is one of the most popular programming language for graphical applications, such as those that run in Windows and Macintosh environments.";
        string topicPHP = "Self-referentially short for PHP: Hypertext Preprocessor, an open source, server-side, HTML embedded scripting language used to create dynamic Web pages.In an HTML document, PHP script (similar syntax to that of Perl or C ) is enclosed within special PHP tags. Because PHP is embedded within tags, the author can jump between HTML and PHP (similar to ASP and Cold Fusion) instead of having to rely on heavy amounts of code to output HTML. And, because PHP is executed on the server, the clientcannot view the PHP code";
        string topicRuby = "Ruby is a dynamic, open-source, object-oriented programming language developed by computer scientist Yukihiro Matsumoto back in the 90s, which makes it one of the youngest languages in broad use.";
        Console.SetWindowSize(100, 58);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Programing Languages");
        Console.WriteLine("---------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("C# (C Sharp): ");
        PrintLines(topicCSharp);
        Console.WriteLine();
        Console.WriteLine("Visual Basic (.NET): ");
        PrintLines(topicVisualBasic);
        Console.WriteLine("Java: ");
        PrintLines(topicJava);
        Console.WriteLine("C++: ");
        PrintLines(topicCPP);
        Console.WriteLine("PHP: ");
        PrintLines(topicPHP);
        Console.WriteLine("Ruby");
        PrintLines(topicRuby);
    }

    static void PrintLines(string content)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        int lineLimit = 60;
        StringBuilder wordLine = new StringBuilder("");
        string[] topic = content.Split(' ');
        for (int index = 0; index < topic.Length; index++)
        {
            wordLine.Append(topic[index]);
            wordLine.Append(" ");
            if ((wordLine.Length > lineLimit) || (index == topic.Length - 1))
            {
                Console.WriteLine(wordLine);
                wordLine.Clear();
            }
        }
        Console.ForegroundColor = ConsoleColor.Blue;
    }

}