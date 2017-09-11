using System;

namespace ex08_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
