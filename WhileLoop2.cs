// this program contains how to use while loop.
// we use '!=' int this program for the while loop condition.



using System;

namespace TO
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {

            int icnt = 0;


            while(icnt != 10)       // "!=" means , is not equal to. which means the loop will Iterate(work or repeat) until icnt = 10; 
            {
                Console.WriteLine("hello world!!");
                icnt++;            
            }

        }

        
    }
}