// this program tells about ForeachLoop

using System;

namespace loop
{
    class ForeachLoop
    {

        static void Main(string[] args)
        {
            int[] age = {16,27,17,20};
           foreach(int icnt in age)
           {
            Console.WriteLine(icnt);
           }
        }

    }
}   
