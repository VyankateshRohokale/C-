using System;

namespace program
{

    class PrivateModifier
    {
         Private string model = "Continental GT";
        static void Main(string[] args)
        {
           
            bike obj1 = new bike();
            Console.WriteLine(obj1.model);

            /*
                 // it will generate the error : 
          Invalid token 'string' in class, struct, or interface member declaration

          as the string's access specifier is private.
            */
        
        
        }
    }
}