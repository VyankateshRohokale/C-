using System;

namespace comparison3
{
    class comparisonoperator3
    {
        static void Main(string[] args)
        {
            int x = 11;
            int y = 51;

            Console.WriteLine(!(x < 5 && x < 10)); // output : true 
            Console.WriteLine(!(y < 25 || y < 50)); // output: true

            // this program returns opposite output due to the use of LogicalNot operator.
            
        }
    }
}