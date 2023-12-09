/* In this program , we print output on the screen using "Console.WriteLine()" which is just like "Printf()" function in 
C programming language */

// there is a explanation of the syntax at the end of the code.

using System;

namespace helloworld
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jay Ganesh ");
            Console.WriteLine("Jay Shree Krishna ");
        
        }
    }
}

/*
   
   Line 6:  "using System;" means that we can use classes from the System namespace.
   Line 7 : it is a blank line, the compiler removes or ignores the blank space or we can say white spaces
               from the code.
   Line 8 : "namespace" is used to organize the code , and it is a container for 
               classes and other namespaces.           
    Line 10 : "class" is a container for data and methods, which brings functionality to your program.
                every line of code that runs in C# must be inside the class.
                In this code the class name is program.
    Line 12 : static ->  In the context of the Main method in your code, the "static" keyword indicates that the Main method can be 
               called without creating an instance of the program class.

               void ->  datatype "void" in the contect of Main method means that the Main function does 
                          not return anything.

                Main -> the Main method indicates that the code will start executing for here.

     Line 14 : "Console.WriteLine()" method is used to print the text inside its curly brackets.
                 ';' -> indicates that the statement ends here.
