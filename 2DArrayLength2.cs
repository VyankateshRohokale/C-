// In this program we find the Length of the 2D array using inbuild function.

using System;

namespace array
{

    class LoopThrough2DArray
    {
        static void Main(string[] args)
        {

            int[,] no = {{11,21,51,101} , { 1,2,3,4,}};
            int a = 0;
            int b = 0;
            int i = 0;

           for(a = 0; a < no.GetLength(0); a++) 
           { 
                for(b = 0; b < no.GetLength(1); b++) 
                { 
                    i++;
                } 
           }  

           Console.WriteLine(i);

        }
    }

}
