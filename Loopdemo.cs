using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.looping
{
    class Loopdemo
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            for (i = 5; i >= 1; i--) 
            {
                Console.WriteLine(i);
            }



        }
    }
}
