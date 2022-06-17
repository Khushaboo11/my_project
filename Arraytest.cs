using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.ArrayExplaination
{
    class Arraytest
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14 };
            for(int i = 1; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        
        
    }
    class Alternate
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a','b', 'c','d','e','f','g','h','i','g','h','i','j','k','l','m','n' };

        }
    }

}
