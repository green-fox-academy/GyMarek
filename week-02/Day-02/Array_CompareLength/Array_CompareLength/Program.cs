using System;


namespace Array_CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3};
            int[] p2 = { 3, 5};

            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`

            if (p2.Length > p1.Length)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();

        }
    }
}
