using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.ArrayExplaination
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 5, 3, 8, 5, 9, 5, 7, 4 };
            Console.WriteLine();
            Console.WriteLine(string.Join("  ",a));
            int max = a[0],min=a[0];
             for( int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(" maximum element ="+max);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine(" minimum element =" + min);
        }
    
    }
}
