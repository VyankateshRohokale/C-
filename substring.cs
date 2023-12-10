using System;

namespace subS
{

class substring
{
    static void Main(string[] args)
    {
        string name = "piyush rohokale";

        int charPos = name.IndexOf("r");

        string lastname = name.Substring(charPos);

        Console.WriteLine(lastname);   
    }
}

}