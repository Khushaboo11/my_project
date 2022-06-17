using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.WhileLooping
{
    class Series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the term you want the number of this series");
            int num = int.Parse(Console.ReadLine());
            int result = (num * num) + (num * num * num);
            Console.WriteLine(" the "+num+" term number of the series is = "+result);
        }
    }
    
}
