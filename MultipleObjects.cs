using System;

namespace program
{
    class hello
    {
        public int age = 16;
        public string name = "piyush";
    }


    class CreatingObject
    {
        static void Main(string[] args)
        {

            hello obj1 = new hello();
            hello obj2 = new hello();
            Console.WriteLine(obj1.name);
            Console.WriteLine(obj2.age);

        }


    }
}

