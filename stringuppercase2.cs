// The error after compilation , "Property or indexer 'string.this[int]' cannot be assigned to -- it is read-only," is because we're trying to modify a character in 
//a string directly, which is not allowed because strings in C# are immutable (cannot be changed).

// this code was written for practice of making lower case to upper case without inbuild function.


using System;

namespace stringUpper
{
    class stringuppercase1
    {

        

        static void Main(string[] args)
        {

            Console.WriteLine("Enter you first name : ");
            
            string name = Console.ReadLine();

            Console.WriteLine("your name is " +name);


            Console.WriteLine("your name in uppercase is " +name.ToUpper());

        }

    }


}
