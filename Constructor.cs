// in this program we use contructor in our program

using System;

namespace program
{
    class bike
    {
        public string model;

         public bike()
         {
            model = "Continental GT";
         }


        class contructor1
        {
             static void Main(string[] args)
        {
            
            bike RoyalEnfield = new bike();
            Console.WriteLine(RoyalEnfield.model);

        }

        }

    }
}
