 /* To Write the same program without using Inbuild Function open 
    "ArrayMax.cs", "ArrayMin.cs", "ArraySum.cs" 
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

            Console.WriteLine(no.Max()); // return the largest from the array
            Console.WriteLine(no.Min()); // return the smallest value from the array
            Console.WriteLine(no.Sum()); // return the sum of all elements from the array

            /* To Write the same program without using Inbuild Function open 
                "ArrayMax.cs", "ArrayMin.cs", "ArraySum.cs".
            */
        }
    }
}