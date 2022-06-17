using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.looping
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int n = int.Parse(Console.ReadLine());
            int x;
            float sum=0,count=0;
            while (n > 0)
            {
                x = n % 10;
                if (x % 2 == 0)
                {
                    sum = sum + x;
                    count++;
                }
                n = n / 10;
            }
            float avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
