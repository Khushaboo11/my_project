using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.looping
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
