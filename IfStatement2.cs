/* this code is almost same as "IfStatement.cs" program , but in 
    this code we also use 'else'.
*/

using System;

namespace statements
{
    class IfStatement2
    {
        static void Main(string[] args)
        {
            int no = 11;

            if(no == 11)
            {
                Console.WriteLine("yes"); // output will be yes if the condition is satisfied.
            }
            else
            {
                Console.WriteLine("no")  // output will be no if the condition is satisfied.
            }
        }
    }
}