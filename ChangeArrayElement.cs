/* 

In this program we change the element of our array.

*/
using System;

namespace array
{
    class Array1
    {
        static void Main(string[] args)
        {
        

            string[] name = {"Vyankatesh", "Vyan" , "Piyush", "Rohokale"};

            name[0] = "PiyushR";

            Console.WriteLine("Name of the person is : "+name[0]);
            
            
            // we changed the first element of our array to "PiyushR".

            
        }

    }
}