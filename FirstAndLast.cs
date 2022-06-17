using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.WhileLooping
{
    class FirstAndLast
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of any digit");
            int num = int.Parse(Console.ReadLine());
            int first, last,result;
            first = num % 10;
            last = num / 10;
            result = first +last;
            Console.WriteLine("sum of first and last digit of the number = "+result);
        }
    }
}
