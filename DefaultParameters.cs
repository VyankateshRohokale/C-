using System;

namespace methods
{
    class ParametersAndArguments
    {
        static void Display(int age = 18)
        {
            Console.WriteLine(age);
        }


        static void Main(string[] args)
        {   

                Display(11);
                Display();
                Display(101);
                Display(51); 

        }

    }
}

