// this program returns the positive value of the user input.
using System;

namespace comparison3
{
    class comparisonoperator3
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter number to convert into positive : ");  
          int x = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine(Math.Abs(x));

                
        }
    }
}
