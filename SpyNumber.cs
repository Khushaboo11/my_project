using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.WhileLooping
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of any digit");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, mul = 1,r;
            while (num > 0)
            {
                r = num % 10;
                sum = sum + r;
                mul = mul * r;
                num = num / 10;
            }
            if (sum == mul)
            {
                Console.WriteLine(" Spy number");
            }
            else
            {
                Console.WriteLine("not a Spy number");
            }
        }
    }
}
