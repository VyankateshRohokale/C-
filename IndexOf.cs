// we can also access the string using IndexOf() as show in this code.

using System;

namespace access
{
    class accessstring2
    {
        static void Main(string[] args)
        {
                string name = "piyush";
                Console.WriteLine(name.IndexOf("p")); // output will be 0, because the IndexOf helps to find the index position of the characters of the string
                                                      // in this case the Index position of 'p' is 0.
        }
    }
}