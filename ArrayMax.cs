/*

    In this program we write the code for finding the maximum number in the array.

*/


using System;
using System.Linq;

namespace System
{
    class SystemLinq
    {   
        static void Main(string[] args)
        {

            int[] no = {11,21,51,101};

               int Max = 0;
            
            foreach(int icnt in no)
            {
               if(icnt >= Max)
               {
                  Max = icnt;
               }
               
            }

            Console.WriteLine(" Maximum number is : "+Max);


        }
    }
}