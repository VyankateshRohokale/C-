// there is also a simple way to write the If Else statements in C#.

using System;

namespace TO
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {

            int age = 16;

            string output = (age < 18) ? "you are an teenager.."  : "you are an adult person...";

            Console.WriteLine(output);

        }
    }
}