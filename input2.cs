using System;

namespace userinput2
{
    class input2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your First Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your NickName : ");
            string nickname = Console.ReadLine();
            
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine()); // we can also use  int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the name of your City : ");
            string address = Console.ReadLine();

            Console.WriteLine("your name is " +name);
            Console.WriteLine("your nickname is " +nickname);
            Console.WriteLine("your age is " +age);
            Console.WriteLine("you live in " +address);

        }
    }
}