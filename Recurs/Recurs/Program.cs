using System;

namespace Recurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.WriteLine(fibonachi(12));
        }
        static int factorial (int x)
        {
            if (x == 0)
                return 1;
            else
                return x * factorial(x - 1);
        }
        static int fibonachi(int x)
        {
            if (x == 0)
                return 0;
            else if (x == 1)
                return 1;
            else
                return fibonachi(x - 1) + fibonachi(x - 2);
        }
    }
}
