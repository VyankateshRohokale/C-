/* just like the previous file "BooleanExpression2.cs" we will print weather the 
    age entered by the user is applicable for voting
*/

// in this program we use real life example for Boolean Expression

using System;

namespace bool2
{
    class booleanexpression3
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter your age (In number's)");
            
            int age = Convert.ToInt32(Console.ReadLine());
            
            int VotingAge = 18;

            if(age >= VotingAge)
            {
                Console.WriteLine("you can vote..");
            }
            else
            {
                Console.WriteLine("you cannot vote..");
            }

        }
    }
}