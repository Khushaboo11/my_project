using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment29_05
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
           for(int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("number is even :"+i);
                }
                else
                {
                    int sqr = i * (-i);
                    Console.WriteLine("number is odd :"+sqr);
                }
            }
        }
    }
}
