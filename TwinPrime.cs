using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment29_05
{
    class TwinPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            int i, count = 0;



            for (i = 2; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    count++;
                }
            }
            for (i = 2; i <num2; i++)
            {
                if (num2 % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(" prime number");
                int diff = num1 - num2;
                if (diff == 2||diff==-2)
                {
                    Console.WriteLine(" these are twin numbers");
                }
                else
                {
                    Console.WriteLine(" these are prime but not twin");
                }
            }
            else
            {
                Console.WriteLine(" not prime number");
            }
        }
    }
}
