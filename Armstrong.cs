using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.WhileLooping
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of any digit");
            int num = int.Parse(Console.ReadLine());
            int sum = 0,r,temp=num;
            while (num > 0)
            {
                r = num % 10;
                sum = sum +( r*r*r);
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("number is Armstrong");
            }
            else
            {
                Console.WriteLine("number is not Armstrong");
            }
        }
    }
}
