using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.basic_fundamentals
{
    class Oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("number is even");

            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }
}
