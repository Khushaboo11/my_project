using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment5_06
{
    class HarshedNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int i,sum=0,temp=num,x;
            while (num > 0)
            {
                x = num % 10;
                sum = sum + x;
                num = num / 10;
            }
            if (temp % sum == 0)
            {
                Console.WriteLine(" Number is Harshed number "+temp);
            }
            else
            {
                Console.WriteLine(" Number is not harshed number "+temp);
            }
        }
    }
}
