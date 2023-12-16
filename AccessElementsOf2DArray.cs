// in this program we access the numbers inside our 2D array.

using System;

namespace array
{
    class TwoDimensionalArray
    {
        
        static void Main(string[] args)
        {
            int[,] no = {{11,21,51,101} , { 1,2,3,4 }};

        Console.WriteLine(no[0,0]); // output : 11
        Console.WriteLine(no[1,2]); // output : 3
        }

    }
}


