using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment5_06
{
    class Number
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if ((i % 5 != 0) && (i % 10 != 0))
                {
                    Console.Write(i + "  ");
                }

            }
        }
    }
}
