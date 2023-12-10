// this Concept of string interpolation was introduced in C# version 6 . make sure you are using version 6 or above.

using System;

namespace interpolation
{

    class stringinterpolation
    {
        static void Main(string[] args)
        {

                Console.WriteLine("enter your first name : ");
                string Fname = Console.ReadLine();

                Console.WriteLine("enter your last name : ");
                string Lname = Console.ReadLine();

                string name = $"your name name is : {Fname} {Lname}";

                Console.WriteLine(name);


        }
    }
}


