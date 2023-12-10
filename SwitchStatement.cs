/* we can also use switch statements instead on if else conditions. But, there is a drawback of switch case . 
 that we cannot apply switch case in case of range */



using System;

namespace TO
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {
                int class = 3;
            switch(class)
            {
                class 1:
                Console.WriteLine("on 1PM");
                break;
                
                class 2:
                Console.WriteLine("on 2PM");
                break;
                
                class 3:                       // the execution will start here as the condition is satisfied.
                Console.WriteLine("on 3PM");    // output will be 3PM
                break;                          // make sure to write "break;" or else the code will be executed till the next case.
                
                class 4:
                Console.WriteLine("on 4PM");
                break;
            }

        }
    }
}