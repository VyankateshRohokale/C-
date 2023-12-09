using System;

namespace assignmentOP
{
    class assignmentoperator
    {
        
        static void Main(string[] args)
        {
              int x = 11;
        x += 3;

        int y = 21;
        y -= 3;

        int z = 51;
        z *= 100;

        int a = 10;
        a /= 2;

        int b = 12;
        b %= 5;

        int c = 10;
        c &= 2;

        int d = 10;
        d |= 2;

        int e = 11;
        e ^= 1;

        int f = 51;
        f >>= 3;

        int g = 51;
        g <<= 3;

        Console.WriteLine("value of a is " +a );
        Console.WriteLine("value of b is " +b );
        Console.WriteLine("value of c is " +c );
        Console.WriteLine("value of d is " +d );
        Console.WriteLine("value of e is " +e );
        Console.WriteLine("value of f is " +f );
        Console.WriteLine("value of g is " +g );
        Console.WriteLine("value of x is " +x );
        Console.WriteLine("value of y is " +y );
        Console.WriteLine("value of z is " +z );
        }

        
    }
}