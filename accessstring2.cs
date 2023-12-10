using System;

namespace access
{

class accessstring2
{
    static void Main(string[] args)
    {
         string name = "piyush";
        
        int i = 0;
        while(name[i] != '\0')
        {
            Console.Write(name[i]);
            i++;
        }
    }
}

}