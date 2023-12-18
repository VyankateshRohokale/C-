using System;

namespace program
{
    class NamedArguments
    {
        static void Display(string person1, string person2, string person3)
        {
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
        }


        static void Main(string[] args)
        {
            Display(person3 : "Piyush", person1 : "Vyankatesh", person2 : "Rohokale");
        }
    }

}