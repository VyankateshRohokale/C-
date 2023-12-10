using System;

namespace string1
{
    class stringlength
    {
        static void Main(string[] args)
        {
            string name = "Piyush Rohokale.";

            int icnt = 0;
            int i = 0;

            for(icnt = 0; name[i] != '.'; i++)
            {
                Console.WriteLine(Convert.ToChar(+name[i]));
                icnt++;
            }

                Console.WriteLine("the length of the string is :  " +i);
        }
    }
}