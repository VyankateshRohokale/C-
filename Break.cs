/* the break statement is used to jump out of the loop if the confition is satisfied.

    In this program as soon as the value of no reaches 17, we jump out of the loop.

*/
using System;

namespace loop
{
    class Break
    {

        static void Main(string[] args)
        {

            int no = 11;

            for(no = 0; no < 20; no++)
            {

                if( no == 17)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("value in no  is :  " +no);
                }

            }

        }

    }
}   
