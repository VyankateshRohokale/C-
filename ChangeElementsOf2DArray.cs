// in this program we change the element in the 2D array 

using System;

namespace array
{
    class ChangeElementsOf2DArray
    {
        static void Main(string[] args)
        {
            int[,] no = {{1,2,3,4} , {11,21,51,101}};

            no[0,0] = 11; // this line changes the element of index {0,0} to 11.

            Console.WriteLine(" the element on  index 0,0 is " +no[0,0]);

        }
    }
}