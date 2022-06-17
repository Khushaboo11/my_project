using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.WhileLooping
{
    class Pallindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to check number is pallindrome or not");
            int num = int.Parse(Console.ReadLine());
            int temp = num, sum = 0,r;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("number is pallindrome");
            }
            else
            {
                Console.WriteLine("number is not pallindrome");
            }
        }
    }
}
