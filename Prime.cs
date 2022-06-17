using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.looping
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num = int.Parse(Console.ReadLine());
            int i, count = 0;
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(" prime number");
            }
            else
            {
                Console.WriteLine(" not prime number");
            }
        }
    }
    class SumOf1to10Prime
    {
        static void Main(string[] args)
        {
            int i, count = 0,sum=0;
            int j;
            for (i = 2; i <= 10; i++)
            {
                for (j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(" it is a prime number"+i);
                }
            }
            Console.WriteLine("sum of all prime numbers between 1 to 10 is "+sum);
        }
    }
}
