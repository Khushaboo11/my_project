using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.looping
{
    class SumNum
    {
        static void Main(string[] args)
        {
            int sum = 0, i;
            for (i = 0; i <= 10; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);
        }
    }
}
