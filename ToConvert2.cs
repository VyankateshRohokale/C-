// in this we convert a bool variable to integer.

using System;

namespace Convert2
{
    class ToConvert2
    {
        static void Main(string[] args)
        {
            bool no = true;

            int ConvertedNo = Convert.ToInt32(no);

            Console.WriteLine(ConvertedNo);
        }
    }
}

