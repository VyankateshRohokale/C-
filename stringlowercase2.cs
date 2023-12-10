// The error after compilation , "Property or indexer 'string.this[int]' cannot be assigned to -- it is read-only," is because we're trying to modify a character in 
//a string directly, which is not allowed because strings in C# are immutable (cannot be changed).

// this code was written for practice of making upper case to lower case without inbuild function.


using System;

namespace stringUpper
{
    class stringuppercase1
    {

        

        static void Main(string[] args)
        {

            Console.WriteLine("Enter you first name in uppercase : ");
            
            string name = Console.ReadLine();

            Console.WriteLine("your name is " +name);


            int a = 0;
           
             while(name[a] != '\0')
            {
                if(name[a] >= 65 && name[a] <= 90)
                {

                    name[a] = (char)(name[a] + 32);

                   a++;
                }
                else
                {
                    a++;
                }
            }

                    Console.WriteLine(name);

        }

    }


}
