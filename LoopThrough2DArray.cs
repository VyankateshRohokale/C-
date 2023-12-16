// in this program we travel the whole array using foreach loop , and print all the elements.

using System;

namespace array
{

    class LoopThrough2DArray
    {
        static void Main(string[] args)
        {

            int[,] no = {{11,21,51,101} , { 1,2,3,4,}};

            foreach(int icnt in no)
            {
                Console.WriteLine(icnt);
            }

        }
    }

}