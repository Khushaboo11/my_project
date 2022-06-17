using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.WhileLooping
{
    class NoOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of any digit");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("Total digit of number = "+count);
        }
    }
}
