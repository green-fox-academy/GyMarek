using System;

namespace Array_IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3, 4, 5 };

            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element

            t[2] ++;

            Console.WriteLine(t[2]);

            Console.ReadLine();
        }
    }
}
