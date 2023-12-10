using System;

namespace lowercase
{

class stringlowercase
{

    static void Main(string[] args)
    {

        Console.WriteLine("enter your name in uppercase : ");

        string name = Console.ReadLine();

        Console.WriteLine("your name is : " +name);

        Console.WriteLine("your name in lower case is " +name.ToLower());


    }


}


}