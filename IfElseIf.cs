/* this code is almost same as "IfStatement2.cs" program , but in 
    this code we also use 'else'.

    This Statement is else if is also called as else if ladder.
*/

using System;

namespace statements
{
    class IfStatement2
    {
        static void Main(string[] args)
        {
            int no = 11;

            if(no == 12)
            {
                Console.WriteLine("yes"); // output will be yes if the condition is satisfied.
            }
            else if(no == 11)
            {
                Console.WriteLine("Inside else if..");
            }
            else
            {
                Console.WriteLine("no")  // output will be no if the condition is satisfied.
            }
        }
    }
}