using System;

namespace concatenation
{
    class stringconcatenation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name : ");

            string Fname = Console.ReadLine();

            Console.WriteLine("Enter your Middle Name : ");

            string Mname = Console.ReadLine();

            Console.WriteLine("Enter your Last Name : ");

            string Lname = Console.ReadLine();

            


            string name = Fname + Mname + Lname;

            Console.WriteLine("your name is : " +name);

                
        
            

        }
    }
}