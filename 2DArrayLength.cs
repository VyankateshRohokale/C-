/* in this program we count the length of the 2D array without using inbuild function.

    to find the length of the 2D array using inbuild function refer " 2DArrayLength2.cs ."

*/

using System;

namespace array
{

    class LoopThrough2DArray
    {
        static void Main(string[] args)
        {

            int[,] no = {{11,21,51,101} , { 1,2,3,4,}};
            int i = 0;

            foreach(int icnt in no)
            {
                    i++;
            }

            Console.WriteLine(" Length of the 2D array is : " +i);

        }
    }

}
