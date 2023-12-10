using System;

namespace bool1
{
    class boolean1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the food tasty? or not?");
            
            string taste = Console.ReadLine();

            bool ans = false;

            if (taste == "yes")
            {
                ans = true;
            }
            else
            {
                
            }

            if (ans == true)
            {
                Console.WriteLine("Yes!!");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}