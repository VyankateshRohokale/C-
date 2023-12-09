// in this program we convert a double variable to integer.

using System;

namespace ToConvert
{
    class convert
    {
        static void Main(string[] args)
        {
            double no = 51.11;
            int convertedNo = Convert.ToInt32(no);

            Console.WriteLine(convertedNo);
        }
    }
}


// output  :   51

