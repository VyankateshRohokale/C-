/*
    In this program we fing th elength of the array without using Inbuild function.
*/

using System;

namespace loop
{
    class ForeachLoop
    {

        static void Main(string[] args)
        {
            int[] age = {10,11,51,101};
          int i = 0;
          
           foreach(int icnt in age)
           {
                i++;
           }

           Console.WriteLine("Length of the array is : "+i);

        }

    }
}   
